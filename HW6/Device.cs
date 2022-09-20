using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HW6
{
    public class Device
    {
         
        public int iD { get; set; }
        public string _name { get; set; }
        public Device()
        {
            _name = "noname";
         
        }
     
        public Device(string _name)
        {
            this._name = _name;
        }
    }
    public interface IDo
    {
        void sound();
        void show();
        void desk();
    }
}
