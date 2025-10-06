using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myworld_memeto
{
    public class GameCharacter
    {
        private int level;
        private int health;
        private string position;

        public int Level
        {
            get { return level; }
            set
            {
                level = value;
                Console.WriteLine($"Level: {level}");
            }
        }

        public int Health
        {
            get { return health; }
            set
            {
                health = value;
                Console.WriteLine($"Health: {health}");
            }
        }

        public string Position
        {
            get { return position; }
            set
            {
                position = value;
                Console.WriteLine($"Position: {position}");
            }
        }

        // Lưu trạng thái hiện tại
        public CharacterMemento SaveState()
        {
            Console.WriteLine("\n[Lưu trạng thái nhân vật]\n");
            return new CharacterMemento(level, health, position);
        }

        // Khôi phục trạng thái từ Memento
        public void RestoreState(CharacterMemento memento)
        {
            Console.WriteLine("\n[Khôi phục trạng thái nhân vật]\n");
            Level = memento.Level;
            Health = memento.Health;
            Position = memento.Position;
        }
    }
}
