using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppGame
{
    internal class Magician : Character, IHealer
    {
        public int magic_point = 100;

        public Magician() : base("魔法使い", 1, 100) { }

        public override int Attack(int damage)
        {
            Console.WriteLine("{0}は魔法を使って{1}攻撃した！", Name, damage);
            return damage;
        }

        public void Healing(int healingPoint)
        {
            Console.WriteLine("{0}は魔法を使って仲間を{1}回復させた！", Name, healingPoint);
            
        }
    }
}
