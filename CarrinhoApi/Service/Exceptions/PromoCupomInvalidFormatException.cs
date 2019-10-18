using System;

namespace CarrinhoApi.Service.Exceptions
{
    public class PromoCupomInvalidFormatException : ApplicationException
    {
        public PromoCupomInvalidFormatException(string message) : base(message)
        {
        }
    }
}
