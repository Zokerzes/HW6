using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace HW6
{
    public class President : Worker
    {
        public President()
        {
            base.name = "Президент";
        }
        public override void print()
        {
            WriteLine($" работает как {name}");
        }
    }
}
