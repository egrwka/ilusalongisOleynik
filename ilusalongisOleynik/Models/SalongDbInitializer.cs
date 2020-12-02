using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using ilusalongisOleynik.Models;

namespace ilusalongisOleynik.Models
{
    public class SalongDbInitializer : DropCreateDatabaseAlways<SalongContext>
    {
        protected override void Seed(SalongContext db)
        {
            // создаем работников салона
            var worker1 = new Worker()
            {
                Name = "Artem Gorodnichev",
                Telephone = "58445856",
                Service = "Juuksur",
                Hind = "" 
            };
            var worker2 = new Worker
            {
                Name = "Криштиану Роналду",
                Service = "",
                Hind =
            };
            var worker3 = new Worker
            {
                Name = "Неймар",
                Age = 23,
                Position = "Нападающий"
            };
            var worker4 = new Worker
            {
                Name = "Луис Суарес",
                Age = 28,
                Position = "Нападающий"
            };
            var worker5 = new Worker
            {
                Name = "Серхио Агуэро",
                Age = 27,
                Position = "Нападающий"
            };
            db.Workers.Add(worker1);
            db.Workers.Add(worker2);
            db.Workers.Add(worker3);
            db.Workers.Add(worker4);
            db.Workers.Add(worker5);
            base.Seed(db);
        }
    }
}