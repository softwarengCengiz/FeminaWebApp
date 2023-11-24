using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FeminaWebApp.Models;

namespace FeminaWebApp.Data
{
    public class FeminaWebAppContext : DbContext
    {
        public FeminaWebAppContext (DbContextOptions<FeminaWebAppContext> options)
            : base(options)
        {
        }

        public DbSet<FeminaWebApp.Models.Customer> Customer { get; set; } = default!;
    }
}
