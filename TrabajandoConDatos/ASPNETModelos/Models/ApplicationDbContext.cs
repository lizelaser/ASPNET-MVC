using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ASPNETModelos.Models
{
    public class ApplicationDbContext: DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }
        public ApplicationDbContext()
        { }
    }
}