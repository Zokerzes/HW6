using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace HW6
{
    public class Kettle : Device, IDo
    {
        public Kettle() : base() 
        {
            show();
            desk();
            sound();
            WriteLine();

        }
        public void desk()
        {
            WriteLine("Просто чайник. Старый, потрёпаный временем и не лёгкой походной жизнью");
        }

        public void show()
        {
            WriteLine("Чайник");
        }

        public void sound()
        {
            WriteLine("Чайник: Свистит закипая");
        }
    }
}
