using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Neogames.Models
{
    public class Purchase
    {
        public int id { get; set; }
        public double Amount { get; set; }
        public DateTime PurchaseDate { get; set; }
    }
}
