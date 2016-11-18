using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CharacterCreator.Models;
using CharacterCreator.Domain;

namespace CharacterCreator.Data
{
    public class Repository : IRepository
    {
        private static Repository repository = new Repository();
        private List<Character> characters = new List<Character>();

        public static Repository GetRepository
        {
            get 
            {
                return repository;
            }
        }

        public Character CreateCharacter()
        {
            return CharacterFactory.CreateCharacter();
        }

        public void DeleteCharacterById(int id)
        {
            throw new NotImplementedException();
        }

        public Character GetCharacterById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Character> GetCharacters()
        {
            return characters;
        }
    }
}