using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BikeExchange.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BikeExchange.Data
{
    //public class BikeDbContext : DbContext
    public class BikeDbContext : IdentityDbContext<IdentityUser>  // HH: In order to use MSFT Identity
    {
        public BikeDbContext(DbContextOptions<BikeDbContext> options) : base(options) { }

        public DbSet<Make> Makes { get; set; }
        public DbSet<Model> Models { get; set; }
    }
}
