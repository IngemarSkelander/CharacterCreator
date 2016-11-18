using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CharacterCreator.Domain
{
    public static class AttributeFactory
    {
        public static List<Attribute> CreateAttributes()
        {
            List<Attribute> attributes = new List<Attribute>();

            Attribute agility = new Attribute() { Name = "Agility", Value = 5 };
            Attribute awareness = new Attribute() { Name = "Awareness", Value = 5 };
            Attribute coordination = new Attribute() { Name = "Coordination", Value = 5 };
            Attribute intelligence = new Attribute() { Name = "Intelligence", Value = 5 };
            Attribute mental = new Attribute() { Name = "Mental Strength", Value = 5 };
            Attribute personality = new Attribute() { Name = "Personality", Value = 5 };
            Attribute physique = new Attribute() { Name = "Physique", Value = 5 };
            Attribute strength = new Attribute() { Name = "Strength", Value = 5 };
            attributes.Add(agility);
            attributes.Add(awareness);
            attributes.Add(coordination);
            attributes.Add(intelligence);
            attributes.Add(mental);
            attributes.Add(personality);
            attributes.Add(physique);
            attributes.Add(strength);
            return attributes;
        }
    }
}