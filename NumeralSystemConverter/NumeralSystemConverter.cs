using System;
using System.Text;

class ConvertFromToAnyNumericalSystem
{
    static void Main()
    {
        Console.WriteLine("Enter A number in a numeral system");
        string numberStr = Console.ReadLine();
        Console.WriteLine("Enter the original base for the numerial system");
        int initialBase = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the desire base");
        int newBase = int.Parse(Console.ReadLine());
        Console.WriteLine(NumberFromSBaseToD(numberStr,initialBase, newBase));
    }
    static string NumberFromSBaseToD(string number, int initialBase, int newBase)
    {
        int tempNumber = ToDecimaNumericSys(number, initialBase);
        string finalNumber = FromDecimalToBase(tempNumber, newBase);
        return finalNumber;
    }
    static int ToDecimaNumericSys(string number, int systemBase)
    {
        number = number.ToUpper();
        int numberLen = number.Length;
        int numberInDecimal = 0;
        for (int i = 0; i < numberLen; i++)
        {
            int digitInInt = 0;
            char digitInChar = (char)number[i];
            if (digitInChar >= 48 && digitInChar < 58)
            {
                digitInInt = (int)digitInChar -48;
            }
            if (digitInChar >= 65 && digitInChar < 91)
            {
                digitInInt = (int)digitInChar - 55;
            }
            numberInDecimal += digitInInt * (int)Math.Pow(systemBase, numberLen - i - 1);
        }
        return numberInDecimal;
    }
    static string FromDecimalToBase(int number, int systemBase)
    {
        if (systemBase != 10)
        {
            StringBuilder numberInNewNumeralSys = new StringBuilder();
            while (number != 0)
            {
                int remnant = number % systemBase;
                number = number / systemBase;
                if (remnant >= 0 && remnant < 10)
                {
                    numberInNewNumeralSys.Append(remnant);
                }
                if (remnant >= 10 && remnant < 16)
                {
                    numberInNewNumeralSys.Append((char)(remnant + 55));
                }
            }
            string numberReversedStr = numberInNewNumeralSys.ToString();
            char[] numberReversedChar = numberReversedStr.ToCharArray();
            Array.Reverse(numberReversedChar);
            string finalAnswer = new string(numberReversedChar);
            return finalAnswer;
        }
        else
        {
            return number.ToString();
        }
    }
}