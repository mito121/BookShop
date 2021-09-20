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

        // Constructor
        public Store()
        {
            // Add newspapers
            Newspaper politikken = new Newspaper();
            politikken.Date = DateTime.Today;
            politikken.Id = 1;
            politikken.Pages = 1337;
            politikken.Price = 420.69m; // 'm' at the end, to fix decimal syntax :-) wtf lol ok
            politikken.Publisher = "Politikken";
            politikken.Title = "De største heste, er dem som græsser mest.";

            Newspaper bt = new Newspaper
            {
                Id = 2,
                Title = "Rensdyrene renses dagligt",
                Date = DateTime.Today,
                Publisher = "BT",
                Pages = 4,
                Price = 13.37m
            };


            // Add newspapers to list
            // List<Newspaper> newsPapers = new List<Newspaper>(); // Denne liste er flyttet til klasseniveau, fremfor i Constructor, så denne liste kan tilgås udenfor Constructoren
            newsPapers.Add(politikken);
            newsPapers.Add(bt);

            // Print antal af aviser
            Console.WriteLine($"Min boghandel indeholder {newsPapers.Count} aviser.");
            
            // Print alle aviser med titel og pris
            foreach (var item in newsPapers) // ELLER foreach (Newspaper item in newsPapers)
            {
                Console.WriteLine($"Titel: {item.Title} | Pris: {item.Price}");
            }
        }

        // Search method
        public void Search()
        {
            Console.WriteLine("Søg efter titel:");
            string searchString = Console.ReadLine();

            // Ny liste over items som matcher
            List<Newspaper> searchResults = new List<Newspaper>();
            foreach (var item in newsPapers)
            {
                if(item.Title.ToLower() == searchString.ToLower())
                {
                    // Udskriv enkelt match
                    // Console.WriteLine(item
                    
                    // Add to list of results
                    searchResults.Add(item);
                }
            }

            if (searchResults.Count < 1)
            {
                // No results
                Console.WriteLine("Ingen søgeresultater!");
            }
            else
            {
                // Print list of results
                // searchResults.ForEach(i => Console.Write("{0}\t", i));
            }
        }
    }
}
