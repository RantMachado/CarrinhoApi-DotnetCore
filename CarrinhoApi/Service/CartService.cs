using System.Text.RegularExpressions;
using CarrinhoApi.Service.Exceptions;
using CarrinhoApi.Service.Interfaces;
using CarrinhoApi.ViewModel;

namespace CarrinhoApi.Service
{
    public class CartService : ICartService
    {

        public void ValidatePromo(CartViewModel cart)
        {
            string promoToValidateFormat = cart.Promocode;
            string pattern = @"[a-zA-Z0-9]{8}";

            try
            {
                Match result = Regex.Match(promoToValidateFormat, pattern);
                
                try
                {
                    string validPromoFormat = result.ToString();

                    //Desconto sobre maior ingresso Restrição apenas para as sessões de sábado e domingo Valor do desconto R$ 12.50 
                    if (validPromoFormat == "YsnPvmhm" || validPromoFormat == "AdPRtqzw" || validPromoFormat == "MxNxhm3q")
                    {
                        if (cart.Session.Date.DayOfWeek.ToString("ddd") == "Sat" || cart.Session.Date.DayOfWeek.ToString("ddd") == "Sun")
                        {
                            FinaldeSemanaDiaDeCinema(cart);
                        }
                    }

                    //Desconto sobre total da compra Restrição para um filme e um cinema Valor do desconto R$ 20.00 
                    if (validPromoFormat == "xttEVw3k" || validPromoFormat == "BCBmzwCX")
                    {
                        if (cart.Session.Event.Name == "Toy Story 4" && cart.Session.Theatre.Name == "Kinoplex RioSul")
                        {
                            CoringaEnoCinema(cart);
                        }
                    }

                    //Desconto sobre menor ingresso Valor do desconto R$ 9.99 
                    if (validPromoFormat == "b9E65dCf" || validPromoFormat == "VgfGVmZp")
                    {
                        IngressoDotCom99(cart);
                    }
                }
                catch (PromotionNotValid)
                {
                    throw new PromotionNotValid("It's invalid cupom!");
                }
            }

            catch (PromoCupomInvalidFormatException)
            {
                throw new PromoCupomInvalidFormatException("Is not valid format for cupom!");
            }
        }

        private void FinaldeSemanaDiaDeCinema(CartViewModel cart)
        {
            cart.TotalPrice -= 12.5;
        }

        private void CoringaEnoCinema(CartViewModel cart)
        {
            cart.TotalPrice -= 20.00;
        }

        private void IngressoDotCom99(CartViewModel cart)
        {
            cart.TotalPrice -= 9.99;
        }
    }
}
