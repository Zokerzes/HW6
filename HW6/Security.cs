using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace HW6
{
    public class Security : Worker
    {
        public Security()
        {
            base.name = "Охранник";
        }
        public override void print()
        {
            WriteLine($" работает как {name}");
        }
    }
}