using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace HW6
{
    public class Automobile : Device, IDo
    {
        public Automobile() : base()
        {
            show();
            desk();
            sound();
            WriteLine();
        }
    public void desk()
        {
            WriteLine("Тёмносиний седан выглядел словно только-что выехал с завода");
        }

        public void show()
        {
            WriteLine("Автомобиль");
        }

        public void sound()
        {
            WriteLine("Автомобиль: звук клаксона");
        }
    }
}