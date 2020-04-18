using System;
using PedeAqui.Core.Shared.Entities;
using PedeAqui.Core.Shared.SeedWork.Enums;
using PedeAqui.Core.Shared.ValueObjects;

namespace PedeAqui.Core.Aggregates.Customer.Entities
{
    public class Customer : BaseEntity
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