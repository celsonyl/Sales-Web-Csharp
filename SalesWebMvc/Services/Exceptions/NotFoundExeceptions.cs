using System;


namespace SalesWebMvc.Services.Exceptions
{
    public class NotFoundExeceptions : ApplicationException
    {
        public NotFoundExeceptions(string message) : base(message)
        {
            
        }

        
    }
}
