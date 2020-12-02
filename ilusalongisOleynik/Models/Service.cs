using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ilusalongisOleynik.Models
{
    public class Service
    {
        public int ServiceId { get; set; }
        public string Services { get; set; }
        public string Hind { get; set; }
        public ICollection<Worker> Workers { get; set; }
        public Service()
        {
            Workers = new List<Worker>();
        }

    }
}