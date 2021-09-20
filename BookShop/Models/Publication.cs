using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop.Models
{
    public class Publication
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Publisher { get; set; }
        public decimal Price { get; set; }

        // Constructor
        public Publication(/*int id*/)
        {
            //Id = id;
        }
    }
}
