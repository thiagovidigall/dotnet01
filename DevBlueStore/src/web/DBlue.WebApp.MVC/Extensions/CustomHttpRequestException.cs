using System;
using System.Net;

namespace DBlue.WebApp.MVC.Extensions
{
    public class CustomHttpRequestException : Exception
    {
        public HttpStatusCode StatuCode;

        public CustomHttpRequestException() { }

        public CustomHttpRequestException(string message, Exception innerException)
            : base(message, innerException) { }
        
        public CustomHttpRequestException(HttpStatusCode statusCode)
        {
            StatuCode = statusCode;
        }
    }
}
