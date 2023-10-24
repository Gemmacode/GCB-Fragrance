using GCBModel.FragranceModel;
using Microsoft.EntityFrameworkCore;

namespace GCBData
{
    public class FDbContext : DbContext
    {
        public FDbContext(DbContextOptions<FDbContext> options) : base(options)
        {
        }
        public DbSet<Fragrance>Fragrances { get; set; }    
    }
}