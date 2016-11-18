using CharacterCreator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CharacterCreator.Domain
{
    public class CharacterFactory
    {
        public static Character CreateCharacter()
        {
            Character c = new Character();
            c.Name = "";
            c.Faction = "";
            c.Attributes = AttributeFactory.CreateAttributes();
            return c;
        }
    }
}