using System;
// Add Model namespacae
using BookShop.Models;

namespace BookShop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Velkommen til boghandlen.");
            Console.WriteLine("");
            Store store = new Store();
            store.Search();
        }
    }
}
