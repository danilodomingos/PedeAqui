namespace PedeAqui.Api.Models
{
    public class MenuItem
    {
        public string Name { get; set; }
        public string PhotoUrl { get; set; }
        public double Price { get; set; }
        public bool IsUnavailable { get; set; }
    }
}