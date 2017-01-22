using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TripleOfLatinLetters
{
    class TripleOfLatinLetters
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int first = 0; first < n; first++)
            {
                for (int second = 0; second < n; second++)
                {
                    for (int third = 0; third < n; third++)
                    {
                        char letter = (char)('a' + first);
                        char secondLetter = (char)('a' + second);
                        char thirdLetter = (char)('a' + third);
                        Console.WriteLine("{0}{1}{1}", letter, secondLetter, thirdLetter);
                    }

                }

            }
        }
    }
}
