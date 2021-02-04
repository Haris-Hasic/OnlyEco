using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;



namespace eZdravaIshrana_PCL.Util
{
    public class WebApiHelper
    {
        private HttpClient client { get; set; }

        private string route { get; set; }

        public WebApiHelper(string uri, string route)
        {
            client = new HttpClient();
            client.BaseAddress = new Uri(uri);
            this.route = route;

        }
        public HttpResponseMessage GetResponse()
        {
            return client.GetAsync(route).Result;
        }
        public HttpResponseMessage GetResponse(string parametar)
        {
            //api/Korisnici
            return client.GetAsync(route+"/"+parametar).Result;
        }

     



        public HttpResponseMessage GetResponseID(object parametar)
        {
         //radi selected value
            return client.GetAsync(route + "/" + parametar).Result;
        }

        public HttpResponseMessage GetResponse2par(string action, object parametar1, object parametar2)
        {
            return client.GetAsync(route + "/" + action + "/" + parametar1 + "/" + parametar2).Result;
        }
        public HttpResponseMessage GetResponse3par(string action, object parametar1, object parametar2, object parametar3)
        {
            return client.GetAsync(route + "/" + action + "/" + parametar1 + "/" + parametar2 + "/" + parametar3).Result;
        }
        public HttpResponseMessage GetResponse4par(string action, object parametar1, object parametar2, object parametar3, object parametar4)
        {
            return client.GetAsync(route + "/" + action + "/" + parametar1 + "/" + parametar2 + "/" + parametar3 + "/" + parametar4).Result;
        }

        public HttpResponseMessage GetActionResponse(string action, string parametar = "")
        {
            //api/Korisnici/SearchKorisnici/parametar
            return client.GetAsync(route + "/" + action + "/" + parametar).Result;
        }
        public HttpResponseMessage GetActionResponseID(string action, int parametar)
        {
            //api/Korisnici/SearchKorisnici/parametar
            return client.GetAsync(route + "/" + action + "/" + parametar).Result;
        }

        public HttpResponseMessage GetActionResponseNoP(string action)
        {
            //api/Korisnici/SearchKorisnici/
            return client.GetAsync(route + "/" + action ).Result;
        }
        public HttpResponseMessage GetActionResponse(string action ,int parametar1=0,int parametar2=0,int parametar3=0, decimal parametar4 = 0,string parametar5 = "", string parametar6 = "")
        {
            //api/Korisnici/SearchKorisnici/parametar
            return client.GetAsync(route + "/" + action + "/" + parametar1 + "/" + parametar2 + "/" + parametar3 + "/" + parametar4 + "/" + parametar5 + "/" + parametar6).Result;
        }
        public HttpResponseMessage PostResponse(Object newObject)
        {
            return client.PostAsJsonAsync(route, newObject).Result;
        }
        public HttpResponseMessage PutResponse(int id,Object existingObject)
        {
            return client.PutAsJsonAsync(route + "/" + id, existingObject).Result;
        }


        public HttpResponseMessage DeleteCustomResponse(string action,int kID)
        {
            return client.DeleteAsync(route + "/" + action + "/" + kID).Result;
        }

        public HttpResponseMessage DeleteResponse(int id)
        {
            return client.DeleteAsync(route + "/" + id).Result;
        }

        public HttpResponseMessage PutCustomResponse(string action,int korisnikID, object korisnik)
        {
            return client.PutAsJsonAsync(route + "/"+action +"/" + korisnikID, korisnik).Result;
        }

        public HttpResponseMessage PostResponseAction(string action,object obj)
        {
            return client.PostAsJsonAsync(route + "/" + action , obj).Result;
        }
    }
}
