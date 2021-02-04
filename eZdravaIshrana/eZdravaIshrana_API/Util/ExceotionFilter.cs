using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Http.Filters;

namespace eZdravaIshrana_API.Util
{
    public class ExceotionFilter:ExceptionFilterAttribute
    {
        public override void OnException(HttpActionExecutedContext actionExecutedContext)
        {
            if (actionExecutedContext.Exception is NotImplementedException)
            {
                HttpResponseMessage msg = new HttpResponseMessage()
                {
                    StatusCode = System.Net.HttpStatusCode.PaymentRequired,
                    Content = new StringContent("Pristup metodi zahtijeva upaltu!"),
                    ReasonPhrase = "Uplata obavezna"
                };
                actionExecutedContext.Response = msg;
            }
        }
    }
}