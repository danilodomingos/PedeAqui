namespace PedeAqui.Api.Models
{
    public class Store
    {
        public string Name { get; set; }
        public string LegalName { get; set; }
        public string Document { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public Address Address { get; set; }
    }
}