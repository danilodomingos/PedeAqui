using System;

namespace PedeAqui.Core.Entities
{
    public class BaseEntity
    {
        public Guid Id { get; private set; }
        public DateTime Created { get; private set; }
        public DateTime Updated { get; private set; }

        public BaseEntity()
        {
            Id = Guid.NewGuid();
            Created = DateTime.Now;
            Updated = DateTime.Now;
        }
    }
}