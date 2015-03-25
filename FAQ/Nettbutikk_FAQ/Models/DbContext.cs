using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
namespace FAQ.Models
{

    public class DatabaseContext : DbContext
    {
        public DatabaseContext()
            : base("name=FAQ")
        {
        }

        public DbSet<Faqs> Faqs { get; set; }
        public DbSet<Categories> Categories { get; set; }
        public DbSet<NewQuestions> NewQuestions { get; set; }

    }

    public class Faqs
    {
        [Key]
        public int Id { get; set; } 
        public String Question { get; set; }
        public String Answer { get; set; }
        public int CategoriesId { get; set; }
        public String CategoriesName { get; set; }
        public Categories Category { get; set; }
        public int frequency { get; set; }
    }

    public class Categories
    {
        [Key]
        public int Id { get; set; }
        public String CatName { get; set; }
        public List<Faqs> Faqs { get; set; }
    }

    public class NewQuestions
    {
        [Key]
        public int Id { get; set; }
        public String Title { get; set; }
        public String Name { get; set; }
        public String Question { get; set; }
        public String Email { get; set; }
    }




    
}