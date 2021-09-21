using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop.Models
{
    public class Store
    {
        // Declare newsPapers list
        List<Newspaper> newsPapers = new List<Newspaper>();
        // Declare book list
        List<Book> books = new List<Book>();

        // Constructor
        public Store()
        {
            // Seed newspapers
            Newspaper politikken = new Newspaper();
            politikken.Date = DateTime.Today;
            politikken.Id = 1;
            politikken.Pages = 1337;
            politikken.Price = 420.69m; // 'm' at the end, to fix decimal syntax :-) wtf lol ok
            politikken.Publisher = "Politikken";
            politikken.Title = "Frank er Ole";

            Newspaper bt = new Newspaper
            {
                Id = 2,
                Title = "Hej jeg er roed",
                Date = DateTime.Today,
                Publisher = "BT",
                Pages = 4,
                Price = 13.37m
            };

            Newspaper DenBruneGedNewspaper = new Newspaper
            {
                Id = 3,
                Title = "Den brune ged",
                Date = DateTime.Today,
                Publisher = "Ekstrabladet",
                Pages = 4,
                Price = 0.50m
            };


            // Add newspapers to list
            // List<Newspaper> newsPapers = new List<Newspaper>(); // Deklerationen af denne liste er flyttet til klasseniveau, fremfor i Constructor, så denne liste kan tilgås udenfor Constructoren
            newsPapers.Add(politikken);
            newsPapers.Add(bt);
            newsPapers.Add(DenBruneGedNewspaper);

            // Print antal af aviser
            //Console.WriteLine($"Min boghandel indeholder {newsPapers.Count} aviser.");


            // Seed books
            Book RavnenOgDenRoedeOern = new Book
            {
                Id = 4,
                Title = "Ravnen og den roede oern",
                Publisher = "Gylledal",
                Author = "Arne Hvaltoft",
                Price = 49.95m,
            };

            Book DenFrodigeFlamingo = new Book
            {
                Id = 5,
                Title = "Den frodige flamingo",
                Publisher = "Gylledal",
                Author = "Ole 'The Eel' Frankersen",
                Price = 600.00m
            };

            Book DenBruneGedBook = new Book
            {
                Id = 5,
                Title = "Den brune ged",
                Publisher = "Eriks bogforlag",
                Author = "Erik Niellermann",
                Price = 19.95m
            };

            // Add books to list
            books.Add(RavnenOgDenRoedeOern);
            books.Add(DenFrodigeFlamingo);
            books.Add(DenBruneGedBook);


            // Print store inventory
            Console.WriteLine("\t-- LAGERSTATUS --");
            // Print all newspapers w/ title, price
            Console.WriteLine("Aviser:");
            foreach (var item in newsPapers) // ELLER foreach (Newspaper item in newsPapers)
            {
                Console.WriteLine($"|| Titel: {item.Title} | Pris: {item.Price}");
            }
            // Print all books w/ title, price
            Console.WriteLine("");
            Console.WriteLine("Boeger:");
            foreach (var item in books) // ELLER foreach (Newspaper item in newsPapers)
            {
                Console.WriteLine($"|| Titel: {item.Title} | Pris: {item.Price}");
            }
        }



        // Search method
        public void Search()
        {
            Console.WriteLine("");
            Console.WriteLine("Soeg efter titel:");
            string searchString = Console.ReadLine();

            // Results matching newspapers
            List<Newspaper> newspaperResults = new List<Newspaper>();
            // Results matching books
            List<Book> bookResults = new List<Book>();


            // Add matching newspapers to results
            foreach (var item in newsPapers)
            {
                if (item.Title.ToLower() == searchString.ToLower())
                {
                    // Add to list of newspaper results
                    newspaperResults.Add(item);
                }
            }

            // Add matching books to results
            foreach (var item in books)
            {
                if (item.Title.ToLower() == searchString.ToLower())
                {
                    // Add to list of newspaper results
                    bookResults.Add(item);
                }
            }

            Console.WriteLine("");
            Console.WriteLine($"RESULTATER FOR SOEGNINGEN '{searchString}':");
            Console.WriteLine("");


            // Print search results for newspapers
            if (newspaperResults.Count > 0)
            {
                // Print list of results
                Console.WriteLine($"Aviser fundet:");
                foreach (var result in newspaperResults) // ELLER foreach (Newspaper item in newsPapers)
                {
                    Console.WriteLine($"|| Titel: {result.Title} | Pris: {result.Price}");
                }
            }


            // Print search results for books
            if (bookResults.Count > 0)
            {
                // Print list of results
                Console.WriteLine("");
                Console.WriteLine($"Boeger fundet:");
                foreach (var result in bookResults) // ELLER foreach (Newspaper item in newsPapers)
                {
                    Console.WriteLine($"|| Titel: {result.Title} | Forfatter: {result.Author}");
                }
            }

            // If no search results
            if(newspaperResults.Count == 0 && bookResults.Count == 0)
            {
                Console.WriteLine("Ingen soegeresultater. Proev igen!");
                Search();
            }
        }
    }
}
