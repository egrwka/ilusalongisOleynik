using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ilusalongisOleynik.Models
{
    public class Broonerimine
    {
        public int BroonerID { get; set; }
        public string Name { get; set; }
        public DateTime Aeg { get; set; }
        public string Protsedura { get; set; }
        public int Telefon { get; set; }
        public decimal Price { get; set; }
    }
}