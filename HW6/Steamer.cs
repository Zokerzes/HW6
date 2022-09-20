using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace HW6
{
    public class Steamer : Device, IDo
    {
        public Steamer() : base()
        {
            show();
            desk();
            sound();
            WriteLine();
        }
    public void desk()
        {
            WriteLine("Пароход давно уже использовался только для прогулок редких туристов ");
        }

        public void show()
        {
            WriteLine("Пароход");
        }

        public void sound()
        {
            WriteLine("Пароход: звук пароходного гудка");
        }
    }
}
