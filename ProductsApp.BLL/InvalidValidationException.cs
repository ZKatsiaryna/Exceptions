using System;

namespace ProductsApp.BLL
{
    public class InvalidValidationException : Exception
    {
        public InvalidValidationException(string message) : base(message)
        {

        }
    }
}
