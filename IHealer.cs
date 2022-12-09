using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppGame
{
    internal interface IHealer
    {
        // 回復魔法
        void Healing(int healPoint);
    }
}
