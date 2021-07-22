using GeneLog.Domain.SeedWork;
using System;

namespace GeneLog.Domain
{
    public class Relationship : Entity
    {
        private Relationship(Guid id) : base(id)
        {
        }

        public Guid FatherId { get; private set; }
        public Guid MotherId { get; private set; }
        public bool IsFormal { get; private set; }

        public void SetFather(Guid fatherId)
        {
            FatherId = fatherId;
        }

        public void SetMother(Guid motherId)
        {
            MotherId = motherId;
        }

        public void SetFormality(bool isFormal)
        {
            IsFormal = isFormal;
        }

        public static class Factory
        {
            public static Relationship Create()
                => new Relationship(Guid.NewGuid());

            public static Relationship Restore(
                Guid id,
                Guid fatherId,
                Guid motherId,
                bool isFormal)
            {
                var relationship = new Relationship(id);
                relationship.FatherId = fatherId;
                relationship.MotherId = motherId;
                relationship.IsFormal = isFormal;

                return relationship;
            }
        }
    }
}
