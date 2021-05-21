using Microsoft.EntityFrameworkCore;

namespace ClairesHairCare.Models
{
  public class HairSalonContext : DbContext
  {
    public virtual DbSet<Stylist> Stylist { get; set; }
    public DbSet<Client> Client { get; set; }

    public HairSalonContext(DbContextOptions options) : base(options) { }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseLazyLoadingProxies();
    }
  }
}