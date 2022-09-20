using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace HW6
{
    public class Violin:MusicIns
    {
         public Violin()
        {
            _name = "Violin";

        }

        public Violin(string _name)
        {
            this._name = _name;
        }
        public override void sound()
        {
            WriteLine($"издает звук музыкального инструмента: {_name}");
        }
        public override void show()
        {
            WriteLine($"название музыкального инструмента: {_name}");
        }
        public override void desk()
        {
            WriteLine($"описание музыкального инструмента: {_name}");
        }
        public override void history()
        {
            WriteLine($"история создания музыкального инструмента: {_name}");
        }
    }
}
    

