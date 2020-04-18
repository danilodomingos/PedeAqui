using PedeAqui.Core.Shared.SeedWork.Enums;

namespace PedeAqui.Core.Shared.ValueObjects
{
    public class Address
    {
        public StatesEnum? State { get; private set; }
        public string City { get; private set; }
        public string Neighborhood { get; private set; }
        public string Street { get; private set; }
        public int? Number { get; private set; }
        public string Complement { get; private set; }
        public string ZipCode { get; private set; }
    }
}