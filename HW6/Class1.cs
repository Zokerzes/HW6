using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace HW6
{
    internal class Money
    {
        string name;
        int whole, fractional;
        public Money()
        {
            name = "defalt";
            whole = 0;
            fractional = 0;
        }
        public override string ToString()
        {
            return $"{whole},{fractional} {name}";
        }
        public Money setMoney(int wh, int fr, string n)
        {
            this.whole = wh;
            this.fractional = fr;
            this.name = n;
            return this;
        }

    }
}
