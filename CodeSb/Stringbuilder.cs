using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeSb
{
    internal class Stringbuilder
    {
        private string _str;

        public int Copacity { get; set; }


       public Stringbuilder(string str, int copacity)
        {
            _str = str;
            Copacity = copacity;
        }

        public string Append(string str)
        {
            string result = string.Empty;


            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == null)
                {
                    Copacity = 0;
                    break;

                }
                if (str[i] != 0)
                {
                    Copacity = 16;
                    result += str[i];
                    break;

                }
                if (str[str.Length - 1] != 0)
                {
                    Copacity *= 2;
                    result += str[i];


                }

            }
            return result;

        }
    }
}
