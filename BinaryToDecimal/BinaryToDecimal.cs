using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryToDecimal
{
    class BinaryToDecimal
    {
        static void Main(string[] args)
        {
            int numberInBinaty = 1010;
            int reminder, count = 0;
            double NumberInDecimal = 0;
            while (numberInBinaty > 0)
            {
                reminder = numberInBinaty % 10;
                NumberInDecimal = NumberInDecimal + reminder * Math.Pow(2, count);
                count++;
                numberInBinaty = numberInBinaty / 10;
            }
            Console.WriteLine(NumberInDecimal);
        }
    }
}
