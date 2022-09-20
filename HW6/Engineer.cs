using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace HW6
{
    internal class Engineer : Worker
    {
        public Engineer()
        {
            base.name = "Инженер";
        }
        public override void print()
        {
            WriteLine($" работает как {name}");
        }
    }
}