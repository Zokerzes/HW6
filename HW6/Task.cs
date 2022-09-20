using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace HW6
{
    internal class Task
    {
        public void task1() 
        {
            WriteLine();
            WriteLine("task1");
            WriteLine();
            Money money = new Money();
            WriteLine(money.ToString());
            money.setMoney(45, 56, "rub");
            WriteLine(money.ToString());
            Product product = new Product("someThing", 234, 50, "rub");
            WriteLine(product.ToString());
            product -= 34.50;
            WriteLine(product.ToString());
        }
        public void task2()
        {
            WriteLine();
            WriteLine("task2");
            WriteLine();
            IDo[] device = new IDo[]
            {
                new Kettle(),new Microwave(),new Automobile(),new Steamer()
            };
        }
        public void task3()
        {
            WriteLine();
            WriteLine("task3");
            MusicIns[] musicIns = new MusicIns[]
            {
                new Violin(), new Trombone(), new Ukulele(), new Cello()
            };
            WriteLine();
            foreach (var item in musicIns)
            {
                item.show();
                item.desk();
                item.sound();
                item.history();

            }
        }
        public void task4()
        {
            WriteLine();
            WriteLine("task4");
            Worker []worker = new Worker[]
            {
                new President(),
                new Security(),
                new Manager(),
                new Engineer(),
            };
            WriteLine();
            foreach (var item in worker)
            {
                item.print();
            }
        }
    }
}
