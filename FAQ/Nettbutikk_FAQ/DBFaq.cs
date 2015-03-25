using FAQ.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Web;

namespace Nettbutikk.FAQ
{
    public class DBFaq
    {
        DatabaseContext db = new DatabaseContext();
        public List<Faq> getAll()
        {
            List<Faq> allFaqs = new List<Faq>();
            var f = db.Faqs.OrderByDescending(x => x.frequency).ToList();
            foreach (var q in f)
            {
                var quest = new Faq()
                {
                    id = q.Id,
                    question = q.Question,
                    answer = q.Answer,
                    catId = q.CategoriesId,
                    freq = q.frequency
                };
                allFaqs.Add(quest);
            }
            return allFaqs;
        }

        public List<NewQuestion> getQuestions()
        {
            List<NewQuestion> quest = new List<NewQuestion>();
            var q = db.NewQuestions.ToList();
            foreach (var item in q)
            {
                var question = new NewQuestion()
                {
                    name = item.Name,
                    email = item.Email,
                    question = item.Question,
                    title = item.Title
                };
                quest.Add(question);
            }
            return quest;
        }

        public List<Faq> getFaqByCategory(int id)
        {
            List<Faq> allFaqs = new List<Faq>();
            var f = db.Faqs.Where(p => p.CategoriesId == id).OrderByDescending(x => x.frequency).ToList();
            foreach (var q in f)
            {
                var quest = new Faq()
                {
                    id = q.Id,
                    question = q.Question,
                    answer = q.Answer,
                    catId = q.CategoriesId,
                    freq = q.frequency,
                    catname = q.CategoriesName
                };
                allFaqs.Add(quest);
            }
            return allFaqs;
        }

        public bool updateFrequency(int id)
        {
            try
            {
                Faqs f = db.Faqs.FirstOrDefault(p => p.Id == id);
                f.frequency++;
                db.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
            
        }
        public bool askQuestion(NewQuestion quest)
        {
            var newquest = new NewQuestions()
            {
                Title = quest.title,
                Name = quest.name,
                Question = quest.question,
                Email = quest.email
            };
            try
            {
                db.NewQuestions.Add(newquest);
                db.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}