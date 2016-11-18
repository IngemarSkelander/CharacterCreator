using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CharacterCreator.Models
{
    public class Character
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public IEnumerable<Domain.Attribute> Attributes { get; set; } 
        public string Faction { get; set; }
    }
}