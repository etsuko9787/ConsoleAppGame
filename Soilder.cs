using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppGame
{
    internal class Soilder:Character
    {
        
        public Soilder():base("戦士", 1, 100) { }
        

        public override int Attack(int damage)
        {
            Console.WriteLine("{0}が{1}攻撃した！", Name, damage);
            return damage;
        }
    }
}
