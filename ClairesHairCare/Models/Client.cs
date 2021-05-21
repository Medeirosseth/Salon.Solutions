namespace ClairesHairCare.Models
{
  public class Client
  {
    public int ClientId { get; set; }
    public int ClientName { get; set; }

    public int StylistId { get; set; }

    public string Description { get; set; }

    public string Appointment { get; set; }
    public virtual Stylist Stylist { get; set; }
  }
}