using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CharacterCreator.Domain
{
    public class Attribute
    {
        public string Name { get; set; }
        public int Value { get; set; }
        public IEnumerable<Skill> Skills { get; set;}
    }
}