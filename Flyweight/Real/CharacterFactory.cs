using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225490_NguyễnThịHuỳnhTrân_Real11_Flyweight
{
    public class CharacterFactory
    {
        private Dictionary<char, Character> characters = new Dictionary<char, Character>();

        public Character GetCharacter(char key)
        {
            if (characters.ContainsKey(key))
            {
                return characters[key];
            }
            else
            {
                Character character = null;

                switch (key)
                {
                    case 'A': character = new CharacterA(); break;
                    case 'B': character = new CharacterB(); break;
                    case 'Z': character = new CharacterZ(); break;
                    default: character = new CharacterDefault(key); break;
                }

                characters.Add(key, character);
                return character;
            }
        }
    }
}
