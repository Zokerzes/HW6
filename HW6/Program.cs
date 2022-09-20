using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace HW6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Money money = new Money();
            WriteLine(money.ToString());
            money.setMoney(45, 56, "rub");
            WriteLine(money.ToString());

            Product product = new Product("someThing", 234, 50, "rub");
            WriteLine(product.ToString());
            product -= 34.50;
            WriteLine(product.ToString());
        }
    }
}
