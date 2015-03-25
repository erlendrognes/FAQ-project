using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace FAQ.Models
{
    public class DBInitializer : DropCreateDatabaseIfModelChanges<DatabaseContext>
    {
        protected override void Seed(DatabaseContext context)
        {
            var faqs = new List<Faqs>
            {
                new Faqs{Question = "Hvor lang tid tar det fra jeg bestiller til varene er levert?", Answer ="Det tar mellom 3 og 5 virkedager.", CategoriesId = 1, frequency = 2, CategoriesName="Transport"},
                new Faqs{Question = "Hvordan kan jeg bestille varer dere ikke har på lager?", Answer="Det er desverre ikke mulig å bestille andre varer enn hva som finnes fra før", CategoriesId = 1, frequency = 4, CategoriesName="Transport"},
                new Faqs{Question = "Hvor får jeg varene levert?", Answer = "Når du har bestilt varer fra oss i Snublevann vil du få varene levert på døra.", CategoriesId=1, frequency = 1, CategoriesName="Transport"},
                new Faqs{Question = "Hvilke tidspunkt gjennomfører dere levering?", Answer = "Vi leverer varene på døren mellom 09:00 - 22:00.", CategoriesId = 1, frequency = 3},
                new Faqs{Question = "Vil det koste meg ekstra for transport?", Answer = "Da snublevann kun har levering av varer er alt inkludert i prisen", CategoriesId = 1, frequency = 1, CategoriesName="Transport"},
                new Faqs{Question = "Jeg ønsker å gjøre en bestilling på en vare jeg vet ikke kan anskaffes på Snublevann.no. Hvordan går jeg frem?", Answer ="Dette vil være privatimport. Fra 1. Juli 2009 kan du importere øl, vin og brennevin til privat bruk uten å søke om tillatelse på forhånd. Dersom du ønsker det kan Snublevann foreta importen på vegne av deg. Ta kontakt med Snublevanns kundesenter, som administrerer ordningen. Kundesenteret har telefon 21 88 55 43, e-postadresse kontakt@snublevann.no.", CategoriesId=2, frequency = 6, CategoriesName="Transport"},
                new Faqs{Question = "Jeg er under 18 år og ønsker å bestille fra dere. Er det mulig?", Answer = "Hos oss kan enhver handle. Vi har ingen restriksjoner på alderskontroll", CategoriesId = 3, frequency = 1, CategoriesName="Sosial kontroll"},
                new Faqs{Question = "Hvorfor må jeg registrere meg for å handle?", Answer = "Vi ønsker kun å selge til registrerte kunder, da det vil være enklere for oss å lagre våre kunders ordrehistorikk i vårt system.", CategoriesId = 4, frequency = 1, CategoriesName="Kunder"},
                new Faqs{Question = "Hvorfor har dere like priser som Vinmonopolet på produktene deres?", Answer = "Hos oss er det billigere å handle da prisene også inkluderer frakt.", CategoriesId=2, frequency = 2, CategoriesName="Varelager"},
                new Faqs{Question = "Kommer dere til å fylle opp nettbutikken med flere varer etterhvert?", Answer = "Om vi ender opp med å bli en stor nok konkurrent for vinmonopolet, vil vi øke varebeholdningen.", CategoriesId=2, frequency = 1, CategoriesName="Varelager"},
                new Faqs{Question = "Hvorfor selger dere ikke Rosévin?", Answer = "Vi vil tilby Rosévin fra April, da det er en vintype som nytes best om sommeren", CategoriesId=2, frequency = 9, CategoriesName="Varelager"},
                new Faqs{Question = "Er det mulig å få varene levert over hele verden?", Answer = "Desverre har vi kun en budbil som kjører på luft og kjærlighet tilgjengelig, dermed er det kun mulig å få varer levert i nærhet til vårt kontor.", CategoriesId = 5, frequency = 7, CategoriesName="Levering"},
                new Faqs{Question = "Hvorfor selger dere til mindreårige?", Answer = "For å komme oss opp og frem har vi bestemt at vi skal selge til alle som kan krype og gå", CategoriesId = 3,frequency = 1, CategoriesName="Sosial kontroll"},
                new Faqs{Question = "Har dere god erfaring med hva dere selger?", Answer = "Som studenter har vi meget god erfaring på hva vi selger", CategoriesId=2, frequency = 10, CategoriesName="Varelager"},
                new Faqs{Question = "Jeg angrer på varene jeg har kjøpt, og ønsker å returnere alt. Er det mulig?", Answer = "Desverre er hver ei krone vi kan tjene på nettbutikken såpass viktig for oss at våre kunder kun har 5 minutter på seg å angre på varekjøpet.", CategoriesId=4, frequency = 1, CategoriesName="Kunder"},
                new Faqs{Question = "Må varene bli sendt rett til meg eller kan jeg hente det på deres kontor?", Answer = "Alle varer skal sendes. Det er ikke mulig å hente varene på egenhånd.", CategoriesId=5, frequency = 12, CategoriesName="Levering"},
                new Faqs{Question = "Gis det rabatt til grupper av mindreårige? Da ingen har spesielt god råd", Answer = "Vi i Snublevann har ingen rabattordninger for noen aldre", CategoriesId=3, frequency = 1, CategoriesName="Sosial kontroll"},
                new Faqs{Question = "Er det returrett om varene ikke holder akseptabel standard?", Answer = "NEI", CategoriesId=4, frequency = 7, CategoriesName="Kunder"},
                new Faqs{Question = "Hvilket budbilselskap bruker dere?", Answer = "For å gjennomføre leveringen raskest mulig benytter vi oss av helikopter og utrykningskjøretøy", CategoriesId=5, frequency=3, CategoriesName="Levering"},
            };
            faqs.ForEach(c => context.Faqs.Add(c));

            var quest = new List<NewQuestions>
            {
                new NewQuestions{Title = "Utviklerjobb", Question = "Jeg lurer på om dere ansetter nye utviklere til deres side?", Email="perhansen@hioa.no", Name ="Per Hansen"},
                new NewQuestions{Title = "Jobbmuligheter", Question = "Jeg er 19 år og har kjørt bil siden jeg tok lappen. Kunne jeg fått muligheten til å levere for dere? Kan stille med volvo 240 mot å få betalt bensin og årskort på rudskogen.", Email="fredrik.raaner@rudskogen.no", Name = "Fredrik Råner Fredriksen"}
            };
            quest.ForEach(c => context.NewQuestions.Add(c));

            var cat = new List<Categories>
            {
                new Categories{CatName = "Transport"},
                new Categories{CatName = "Varelager"},
                new Categories{CatName = "Sosial kontroll"},
                new Categories{CatName = "Kunder"},
                new Categories{CatName = "Levering"}
            };
            cat.ForEach(c => context.Categories.Add(c));
            context.SaveChanges();
        }
    }
}