using System;

using Flunt.Notifications;

namespace Store.Domain.Entities
{
    public class Entity : Notifiable
    {
        public Entity(Guid id)
        {
            Id = id;
        }

        public Guid Id { get; private set; }
    }
}