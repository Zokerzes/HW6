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
        public string name;
        public int whole, fractional;
        public Money()
        {
            name = "defalt";
            whole = 0;
            fractional = 0;
        }
        public Money(int wh, int fr, string n)
        {
            name = n;
            whole = wh;
            fractional = fr;
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
        public Money setMoney(string n)
        {
            this.name = n;
            return this;
        }

    }
}
