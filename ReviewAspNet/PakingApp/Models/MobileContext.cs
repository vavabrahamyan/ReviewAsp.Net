using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace PakingApp.Models
{
    public class MobileContext : DbContext
    {
        public DbSet<Phone> Phones { get; set; }
    }
    public class MobileDbIntializer : DropCreateDatabaseAlways<MobileContext>
    {
        protected override void Seed(MobileContext context)
        {
            context.Phones.Add(new Phone { Model = "Samsung Galaxy III", Producer = "Samsung" });
            context.Phones.Add(new Phone { Model = "Samsung Ace II", Producer = "Samsung" });
            context.Phones.Add(new Phone { Model = "HTC Hero", Producer = "HTC" });
            context.Phones.Add(new Phone { Model = "HTC One S", Producer = "HTC" });
            context.Phones.Add(new Phone { Model = "HTC One X", Producer = "HTC" });
            context.Phones.Add(new Phone { Model = "LG Optimus 3D", Producer = "LG" });
            context.Phones.Add(new Phone { Model = "Nokia N9", Producer = "Nokia" });
            context.Phones.Add(new Phone { Model = "Samsung Galaxy Nexus", Producer = "Samsung" });
            context.Phones.Add(new Phone { Model = "Sony Xperia X10", Producer = "SONY" });
            context.Phones.Add(new Phone { Model = "Samsung Galaxy II", Producer = "Samsung" });
            context.SaveChanges();
        }
    }
}