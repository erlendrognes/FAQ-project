using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FAQ.Models
{
    public class Category
    {
        public int id { get; set; }
        public String categoryname { get; set; }
        public List<Faq> catFaq { get; set; }
    }
}