using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BikeExchange.Models;
using Microsoft.EntityFrameworkCore;

namespace BikeExchange.Data
{
    public class BikeDbContext : DbContext
    {
        public BikeDbContext(DbContextOptions<BikeDbContext> options) : base(options) { }

        public DbSet<Make> Makes { get; set; }
        public DbSet<Model> Models { get; set; }
    }
}
