using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Urfancode
{
    //Task1.1 Book class
    internal class Book : Product
    {
        public string authorName;
        public int paceCount;
        public int disCountPersent;

        public Book(string authorName, int paceCount, int disCountPersent, string name, float costPrice, float saledPrice) : base(name, costPrice, saledPrice)
        {
            this.authorName = authorName;
            this.paceCount = paceCount;
            this.disCountPersent = disCountPersent;
        }
        //task1.2 Getinfo method
        public void Getinfo()
        {
            Console.WriteLine($"authorname={this.authorName} <=> paceCount={this.paceCount};\ndisCountPersent={this.disCountPersent} <=> name ={this.name};\ncostPrice={this.costPrice} <=> SaledPrice={this.saledPrice};\n");
        }
        //Task1.3 GetDiscountedPrice method
        public float GetDiscountedPrice()
        {
            return saledPrice - ((saledPrice * disCountPersent) / 100);
        }
    }
}
