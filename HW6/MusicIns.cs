using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace HW6
{
    public class MusicIns
    {       
        public string _name { get; set; }
        public MusicIns()
        {
            _name = "noname";

        }

        public MusicIns(string _name)
        {
            this._name = _name;
        }
        public virtual void sound()
        {
            WriteLine($"издает звук музыкального инструмента: {_name}");
        }
        public virtual void show()
        {
            WriteLine($"название музыкального инструмента: {_name}");
        }
        public virtual void desk()
        {
            WriteLine($"описание музыкального инструмента: {_name}");
        }
        public virtual void history()
        {
            WriteLine($"история создания музыкального инструмента: {_name}");
        }
    }
}
    

