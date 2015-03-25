using FAQ.Models;
using Nettbutikk.FAQ;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web.Http;
using System.Web.Script.Serialization;

namespace Nettbutikk_FAQ.Controllers
{
    public class QuestionController : ApiController
    {
        DBFaq dbFaq = new DBFaq();

        // GET api/question/
        public HttpResponseMessage GetAsked()
        {
            List<NewQuestion> allquest = dbFaq.getQuestions();

            var Json = new JavaScriptSerializer();
            string JsonString = Json.Serialize(allquest);

            return new HttpResponseMessage()
            {
                Content = new StringContent(JsonString, Encoding.UTF8, "application/json"),
                StatusCode = HttpStatusCode.OK
            };
        }

        // POST api/question/
        public HttpResponseMessage askQuestion(NewQuestion question)
        {
            if (ModelState.IsValid)
            {
                bool OK = dbFaq.askQuestion(question);
                if (OK)
                {
                    return new HttpResponseMessage()
                    {
                        StatusCode = HttpStatusCode.OK
                    };
                }
            }
            return new HttpResponseMessage()
            {
                StatusCode = HttpStatusCode.BadRequest,
                Content = new StringContent("Ugyldig input")
            };
        }
    }
}
