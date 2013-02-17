using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShortInBinary
{
    class ShortInBinary
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a 'Short' Number");
            short number = short.Parse(Console.ReadLine());
            StringBuilder numbeInBin = new StringBuilder();
            for (int i = 7; i >= 0; i--)
            {
                numbeInBin.Append(GetBitAtPosition((uint)number, i));
            }
            Console.WriteLine(numbeInBin);
        }
        public static int GetBitAtPosition(uint number, int position)
        {
            uint mask = (uint)1 << position;
            uint maskAndNumber = number & mask;
            return Convert.ToInt32(maskAndNumber >> position);
        }
    }
}
