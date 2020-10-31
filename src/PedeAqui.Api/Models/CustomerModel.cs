using PedeAqui.Core.Shared.SeedWork.Enums;
using System;

namespace PedeAqui.Api.Models
{
    public class CustomerModel
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string NickName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime? BirthDate { get; set; }
        public GenderEnum Gender { get; set; }
        public string AvatarUrl { get; set; }
        public AddressModel Address { get; set; }
    }
}