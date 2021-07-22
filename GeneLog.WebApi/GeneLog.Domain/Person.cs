using System;
using GeneLog.Domain.SeedWork;

namespace GeneLog.Domain
{
    public class Person : Entity
    {
        private Person(Guid id) : base(id)
        {
        }

        public string Name { get; private set; }
        public string Surename { get; private set; }
        public Event Birth { get; private set; }
        public Event Death { get; private set; }
        public Guid RelationshipId { get; private set; }

        public void SetName(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException($"'{nameof(name)}' cannot be null or whitespace.", nameof(name));

            Name = name;
        }

        public void SetSurname(string surname)
        {
            if (string.IsNullOrWhiteSpace(surname))
                throw new ArgumentException($"'{nameof(surname)}' cannot be null or whitespace.", nameof(surname));

            Surename = surname;
        }

        public void SetBirth(Event bitrh)
        {
            if (bitrh is null) throw new ArgumentNullException(nameof(bitrh));
            Birth = bitrh;
        }

        public void SetDeath(Event death)
        {
            if (death is null) throw new ArgumentNullException(nameof(death));
            Death = death;
        }

        public void SetRelationship(Guid relationshipId)
        {
            RelationshipId = relationshipId;
        }

        public static class Factory
        {
            public static Person Create()
                => new Person(Guid.NewGuid());

            public static Person Restore(
                Guid id,
                string name,
                string surname,
                Event birth,
                Event death,
                Guid relationshipId)
            {
                var person = new Person(id);
                person.Name = name;
                person.Surename = surname;
                person.Birth = birth;
                person.Death = death;
                person.RelationshipId = relationshipId;

                return person;
            }
        }
    }
}
