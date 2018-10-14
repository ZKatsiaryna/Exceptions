using System;

namespace ProductsApp.BLL
{
    public class InvalidProductExeptions : Exception
    {
        public InvalidProductExeptions(string message) : base(message)
        {

        }
    }
}
