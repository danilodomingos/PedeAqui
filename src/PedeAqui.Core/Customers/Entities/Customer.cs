using PedeAqui.Core.Shared;
using PedeAqui.Core.Shared.SeedWork.Enums;
using PedeAqui.Core.Shared.ValueObjects;
using System;

namespace PedeAqui.Core.Customers.Entities
{
    public class Customer : BaseEntity
    {
        public string Name { get; }
        public string LastName { get; }
        public string NickName { get; }
        public string Email { get; }
        public string Phone { get; }
        public DateTime? BirthDate { get; }
        public GenderEnum Gender { get; }
        public string AvatarUrl { get; }
        public Address Address { get; }
    }
}