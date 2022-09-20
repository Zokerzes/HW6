using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace HW6
{
    public class Microwave : Device, IDo
    {
        public Microwave() : base()
        {
            show();
            desk();
            sound();
            WriteLine();
        }
        public void desk()
        {
            WriteLine("Миковолновка стояла на высоте среднего человеческого роста и " +
                "блестела своей чёрной глянцевой передней панелью");
        }

        public void show()
        {
            WriteLine("Микроволновка");
        }

        public void sound()
        {
            WriteLine("Микроволновка: Сначала гудит вентилятор, затем раздаётся звук \"Диннньк\"");
        }
    }
}
