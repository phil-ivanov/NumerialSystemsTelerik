using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecimalToHexadecimal
{
    class DecimalToHexadecimal
    {
        static void Main(string[] args)
        {
            int numbInDec = 255;
            string numberInHex = numbInDec.ToString("X");
            Console.WriteLine(numberInHex);
        }
    }
}
