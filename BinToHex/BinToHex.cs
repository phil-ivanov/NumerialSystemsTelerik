using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinToHex
{
    class BinToHex
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a binary number");
            string numInBin = Console.ReadLine();
            StringBuilder numberInHex = new StringBuilder();
            for (int i = 0; i < numInBin.Length; i+=4)
            {
                numberInHex.Append(BinaryToHexidecimal(numInBin.Substring(i, 4)));

            }
            Console.WriteLine(numberInHex);
        }
        static char BinaryToHexidecimal(string number)
        {
            char hexRepresentation = ' ';
            switch (number)
            {
                case "0000":hexRepresentation = '0'; break;
                case "0001": hexRepresentation = '1'; break;
                case "0010": hexRepresentation = '2'; break;
                case "0011": hexRepresentation = '3'; break;
                case "0100": hexRepresentation = '4'; break;
                case "0101": hexRepresentation = '5'; break;
                case "0110": hexRepresentation = '6'; break;
                case "0111": hexRepresentation = '7'; break;
                case "1000": hexRepresentation = '8'; break;
                case "1001": hexRepresentation = '9'; break;
                case "1010": hexRepresentation = 'A'; break;
                case "1011": hexRepresentation = 'B'; break;
                case "1100": hexRepresentation = 'C'; break;
                case "1101": hexRepresentation = 'D'; break;
                case "1110": hexRepresentation = 'E'; break;
                case "1111": hexRepresentation = 'F'; break;
            }
            return hexRepresentation;
        }
    }
}
