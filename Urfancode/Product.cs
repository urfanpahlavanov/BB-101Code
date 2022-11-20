using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Urfancode
{
    //Task1.1 Product class
    internal class Product
    {

        public string name;
        public float costPrice;
        public float saledPrice;
        public Product(string name, float costPrice, float saledPrice)
        {
            this.name = name;
            this.costPrice = costPrice;
            this.saledPrice = saledPrice;
        }
    }
}
