using System;
using System.ComponentModel.DataAnnotations;
namespace ClairesHairCare.Models


{
  public class Client
  {
    public int ClientId { get; set; }
    [Required]
    public string ClientName { get; set; }
    [Required]
    public int StylistId { get; set; }
    [Required]
    public string Description { get; set; }

    public DateTime Appointment { get; set; }
    public virtual Stylist Stylist { get; set; }
  }
}