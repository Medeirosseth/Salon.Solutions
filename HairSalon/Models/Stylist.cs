using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ClairesHairCare.Models
{
  public class Stylist
  {
    public Stylist()
    {
      this.Clients = new HashSet<Client>();
    }

    public int StylistId { get; set; }
    [Required]
    public string StylistName { get; set; }
    public virtual ICollection<Client> Clients { get; set; }
  }
}