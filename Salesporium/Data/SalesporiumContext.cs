using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Salesporium.Models;

namespace Salesporium.Data
{
    public class SalesporiumContext : IdentityDbContext
    {
        public SalesporiumContext (DbContextOptions<SalesporiumContext> options)
            : base(options)
        {
        }

        public DbSet<Salesporium.Models.Sales> Sales { get; set; }
    }
}
