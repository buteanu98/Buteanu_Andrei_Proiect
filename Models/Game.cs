using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Buteanu_Andrei_Proiect.Models
{
    public class Game
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Developer { get; set; }
        public string Publisher { get; set; }
        public decimal Price { get; set; }
        public int Rating { get; set; }
        public ICollection<Order> Orders { get; set; }

    }
}
