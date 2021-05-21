using Microsoft.EntityFrameworkCore;

namespace ClairesHairCareModels
{
  public class ClairsHairCareContext : DbContext
  {
    public virtual DbSet<Stylist> Stylist { get; set; }
    public DbSet<Client> Client { get; set; }

    public ClairsHairCareContext(DbContextOptions options) : base(options) { }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseLazyLoadingProxies();
    }
  }
}