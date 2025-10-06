using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myworld_memeto
{
    public class CharacterMemento
    {
        public int Level { get; set; }
        public int Health { get; set; }
        public string Position { get; set; }

        public CharacterMemento(int level, int health, string position)
        {
            Level = level;
            Health = health;
            Position = position;
        }
    }
}
