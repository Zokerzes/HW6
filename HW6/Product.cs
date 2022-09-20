using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW6
{
    internal class Product : Money
    {
        public string productName;

        public Product(string productName, int wh, int fr, string n) : base(wh, fr, n)
        {
            this.productName = productName;
        }

        public override string ToString()
        {
            return $"Produkt {productName} {base.ToString()}";
        }
        /// <summary>
        /// метод, позволяющий уменьшить цену на заданное число
        /// </summary>
        /// <param name="product"></param>
        /// <param name="num"></param>
        /// <returns></returns>
        public static Product operator -(Product product, double num)
        {
            int wh = (int)num;
            int fr = (int)((num - wh) * 100);
            product.whole -= wh;
            product.fractional -= fr;
            return product;
        }



    }
}
