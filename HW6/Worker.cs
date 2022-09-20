using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW6
{
   
    public abstract class Worker
    { 
        
        public string name="";
        public abstract void print();
        public Worker()
        {
            name = "worker";
        }
    }
}
