using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HexToBin
{
    class HexToBin
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Hexidecimal NUmber");
            string numberStr = Console.ReadLine();
            numberStr = numberStr.ToUpper();
            StringBuilder numberBin = new StringBuilder();
            string numberForAppending = "";
            for (int i = 0; i < numberStr.Length; i++)
            {
                char numberFragment = numberStr[i];
                switch (numberFragment)
                {
                    case '0': numberForAppending = "0000"; break;
                    case '1': numberForAppending = "0001"; break;
                    case '2': numberForAppending = "0010"; break;
                    case '3': numberForAppending = "0011"; break;
                    case '4': numberForAppending = "0100"; break;
                    case '5': numberForAppending = "0101"; break;
                    case '6': numberForAppending = "0110"; break;
                    case '7': numberForAppending = "0111"; break;
                    case '8': numberForAppending = "1000"; break;
                    case '9': numberForAppending = "1001"; break;
                    case 'A': numberForAppending = "1010"; break;
                    case 'B': numberForAppending = "1011"; break;
                    case 'C': numberForAppending = "1100"; break;
                    case 'D': numberForAppending = "1101"; break;
                    case 'E': numberForAppending = "1110"; break;
                    case 'F': numberForAppending = "1111"; break;
                }
                numberBin.Append(numberForAppending);
            }
            Console.WriteLine(numberBin);
        }
    }
}
