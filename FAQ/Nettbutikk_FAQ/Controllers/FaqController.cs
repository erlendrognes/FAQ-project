using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web.Http;
using System.Web.Script.Serialization;
using System.Net.Http.Formatting;
using System.Data.Common;
using Nettbutikk.FAQ;
using FAQ.Models;

namespace Nettbutikk_FAQ.Controllers
{
    public class FaqController : ApiController
    {
        DBFaq dbFaq = new DBFaq();

        // GET api/Faq/
        public HttpResponseMessage Get()
        {
            List<Faq> allFaq = dbFaq.getAll();

            var Json = new JavaScriptSerializer();
            string JsonString = Json.Serialize(allFaq);

            return new HttpResponseMessage(){
                Content = new StringContent(JsonString, Encoding.UTF8, "application/json"),
                StatusCode = HttpStatusCode.OK 
            };
             
        }
        
        // GET api/Faq/
        public HttpResponseMessage Get(int id)
        {
            List<Faq> allFaq = dbFaq.getFaqByCategory(id);

            var Json = new JavaScriptSerializer();
            string JsonString = Json.Serialize(allFaq);

            return new HttpResponseMessage()
            {
                Content = new StringContent(JsonString, Encoding.UTF8, "application/json"),
                StatusCode = HttpStatusCode.OK
            };
        }

        // POST api/Faq/
        public HttpResponseMessage postFaq(int id)
        {
            bool OK = dbFaq.updateFrequency(id);
            if (OK)
            {
                return new HttpResponseMessage()
                {
                    StatusCode = HttpStatusCode.OK
                };
            }
            return new HttpResponseMessage(){
                StatusCode = HttpStatusCode.InternalServerError,
                Content = new StringContent("Could not update object")
            };
        }

    }
}
