namespace HairSalon.Models
{
  public class Client
  {
    public int ClientId { get; set; }
    public int Name { get; set; }
    public string Style { get; set; }
    public int Phone { get; set; }
    public string StylistId { get; set; }
    public virtual Stylist Stylist { get; set; }
  }
}