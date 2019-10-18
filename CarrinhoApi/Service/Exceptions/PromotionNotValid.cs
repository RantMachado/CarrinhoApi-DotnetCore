using System;

namespace CarrinhoApi.Service.Exceptions
{
    public class PromotionNotValid : ApplicationException
    {
        public PromotionNotValid(string message) : base(message)
        {
        }
    }
}
