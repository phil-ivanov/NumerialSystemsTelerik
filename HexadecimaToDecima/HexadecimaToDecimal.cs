using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HexadecimaToDecima
{
    class HexadecimaToDecimal
    {
        static void Main(string[] args)
        {
            string numbInHex = "FF";
            int numbInDec = Convert.ToInt32(numbInHex, 16);
            Console.WriteLine(numbInDec);
        }
    }
}
