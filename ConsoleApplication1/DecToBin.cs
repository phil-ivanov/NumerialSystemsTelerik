using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class DecToBin
    {
        static void Main(string[] args)
        {
            int numb = 5;
            int numbInBin = int.Parse(Convert.ToString(numb, 2));
            Console.WriteLine(numbInBin);
        }
    }
}
