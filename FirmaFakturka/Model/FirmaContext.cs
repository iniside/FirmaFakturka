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
        public DbSet<Client> Clients;
    }
}
