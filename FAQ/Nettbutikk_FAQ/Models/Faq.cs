using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
//using System.Web.Mvc;

namespace FAQ.Models
{
    public class Faq
    {
        [Display(Name = "ID")]
        public int id { get; set; }
        [Display(Name = "Spørsmål")]
        public String question { get; set; }
        [Display(Name = "Svar")]
        public String answer { get; set; }
        [Display(Name = "Populære")]
        public int freq { get; set; }
        [Display(Name="Kategori")]
        public int catId { get; set; }
        public String catname { get; set; }
        //public IEnumerable<SelectListItem> categoryList { get; set; }
    }
}