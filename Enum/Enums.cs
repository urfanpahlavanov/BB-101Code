using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum
{
    public class Enums
    {
        public enum Currency
        {
            Usd,
            Eur,
            Try,
            Rub,
            TRY
        }
        class Value
        {
            public static double MethodCurrency(Currency money,double value)
            {
                if (money == Currency.Usd)
                {
                    return value * 0.59;

                }
                else if(money == Currency.Eur)
                {
                    return value * 0.53;

                }
                else if(money == Currency.Try)
                {
                    return value * 8.73;
                }
                else if(money== Currency.Rub)
                {
                    return value * 52.21;
                }
                return 0;
            }
        }
    }
}
