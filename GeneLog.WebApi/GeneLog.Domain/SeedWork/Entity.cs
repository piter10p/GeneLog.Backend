using System;

namespace GeneLog.Domain.SeedWork
{
    public class Entity
    {
        public Entity(Guid id)
        {
            Id = id;
        }

        public Guid Id { get; }
    }
}
