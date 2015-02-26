using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace FirmaFakturka.Model
{
    class FirmaContext : DbContext
    {
        public FirmaContext()
            : base("FirmaContext")
        {
            Database.SetInitializer<FirmaContext>(new DbInitializer());
           // using (FirmaContext ctx = new FirmaContext())
          //      ctx.Database.Initialize(false);
        }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<Product> Products { get; set; }
    }

    class DbInitializer : DropCreateDatabaseAlways<FirmaContext>
    {
        protected override void Seed(FirmaContext context)
        {
            context.Clients.Add(new Client()
                {
                    Name = "Test 1"
                });
            context.Clients.Add(new Client()
                {
                    Name = "Test 2"
                });
            context.Clients.Add(new Client()
                {
                    Name = "Test 3"
                });
            context.Clients.Add(new Client()
                {
                    Name = "Test 4"
                });
            context.Clients.Add(new Client()
                {
                    Name = "Test 5"
                });
            base.Seed(context);
        }
    }
}
