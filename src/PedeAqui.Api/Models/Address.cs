using PedeAqui.Core.Shared.SeedWork.Enums;

namespace PedeAqui.Api.Models
{
    public class Address
    {
        public StatesEnum? State { get; set; }
        public string City { get; set; }
        public string Neighborhood { get; set; }
        public string Street { get; set; }
        public int? Number { get; set; }
        public string Complement { get; set; }
        public string ZipCode { get; set; }
    }
}