using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW6
{
    internal class Product:Money
    {
        public string productName;
        //public Money price = new Money();
        
        public Product(string productName,int wh, int fr, string n ):base(wh, fr, n)
        {
            this.productName = productName;
        }

        public override string ToString()
        {
            return $"Produkt {productName} {base.ToString()}";
        }
    }
}
