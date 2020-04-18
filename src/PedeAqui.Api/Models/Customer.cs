using System;
using PedeAqui.Core.Shared.SeedWork.Enums;

namespace PedeAqui.Api.Models
{
    public class Customer
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string NickName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime? BirthDate { get; set; }
        public GenderEnum Gender { get; set; }
        public string AvatarUrl { get; set; }
        public Address Address { get; set; }
    }
}