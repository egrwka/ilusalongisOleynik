using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ilusalongisOleynik.Models
{
    public class Worker
    {
        public int WorkerId { get; set; }
        public string Name { get; set; }
        public string Telephone { get; set; }
        public int? ServiceId { get; set; }
        public Service Service { get; set; }
    }

}