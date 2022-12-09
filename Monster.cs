using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppGame
{
    internal abstract class Monster
    {
        private string name;
        private int level;
        private int health_point;

        public Monster(string name, int level, int health_point)
        {
            this.name = name;
            this.level = level;
            this.health_point = health_point;
        }   

        public string Name
        {
            set { this.name = value; }
            get { return name; }
        }

        public int Level
        {
            set { this.level = value; }
            get { return level; }
        }

        public int HealthPoint
        {
            set { health_point = value; }
            get { return health_point; }
        }

        public abstract int Attack(int damage);
    }
}
