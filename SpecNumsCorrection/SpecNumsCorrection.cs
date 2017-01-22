using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecNumsCorrection
{
    class SpecNumsCorrection
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            for (int num = 1; num <= n; num++)
            {
                int sumOfDigits = 0;
                int digit = 0;
                while (digit > 0)
                {
                    sumOfDigits += digit % 10;
                    digit = digit / 10;
                    bool special = false;
                    if ((sumOfDigits == 5) || (sumOfDigits == 7) || (sumOfDigits == 11))
                    {
                        special = true;
                    }
                    Console.WriteLine("{0} -> {0}", num, special);
                }
                
            }
        }
    }
}
