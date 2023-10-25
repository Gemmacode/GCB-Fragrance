using GemsModel.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GemsData.FragranceDbContext
{
    public class GDbContext : DbContext
    {
        public GDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Fragrance>Fragrances { get; set; } 
    }
}
