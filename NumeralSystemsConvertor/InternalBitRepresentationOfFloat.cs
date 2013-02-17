using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace NumeralSystemsConvertor
{
    class InternalBitRepresentationOfFloat
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;

            float number = float.Parse(Console.ReadLine());

            byte[] raw = BitConverter.GetBytes(number);
            string bitsInFloat = BitsFromByteArray(raw);
            string signBit = bitsInFloat[0].ToString();
            string exponent = bitsInFloat.Substring(1, 8);
            string mantissa = bitsInFloat.Substring(9, 23);
            Console.WriteLine("The sign bit is {0} the exponent is {1} and\n\rthe mantissa is {2}", signBit, exponent, mantissa);
        }
        static string BitsFromByteArray(byte[] raw)
        {
            StringBuilder bitsString = new StringBuilder();
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    bitsString.Append(GetBitAtPosition(raw[i], j));
                }
            }
            char[] bits = bitsString.ToString().ToCharArray();
            Array.Reverse(bits);
            return new string(bits);
        }
        public static int GetBitAtPosition(uint number, int position)
        {
            uint mask = (uint)1 << position;
            uint maskAndNumber = number & mask;
            return Convert.ToInt32(maskAndNumber >> position);
        }
    }
}
