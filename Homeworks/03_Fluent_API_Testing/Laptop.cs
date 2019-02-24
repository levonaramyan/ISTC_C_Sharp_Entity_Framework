using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Fluent_API_Testing
{
    public class Laptop
    {
        public int IdentificationNumber { get; set; }
        public string Name { get; set; }
        public double Discount { get; set; }
        public decimal Price { get; set; }
    }

    public class Phone
    {
        public int IdentificationNumber { get; set; }
        public string Name { get; set; }
        public int Discount { get; set; }
        public int Price { get; set; }
    }
}
