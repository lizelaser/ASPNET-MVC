using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ASPNETScaffolding.Models
{
    public class ApplicationDbContext: DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }
    }
}