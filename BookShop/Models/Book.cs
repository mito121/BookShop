using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop.Models
{
    public class Book : Publication
    {
        public string Author { get; set; }
        public long Isbn { get; set; }
    }
}
