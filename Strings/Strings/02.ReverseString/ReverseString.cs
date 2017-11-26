using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.ReverseString
{
    class ReverseString
    {
        static void Main(string[] args)
        {
            string toBeReverted = Console.ReadLine();

            StringBuilder revertedSB = new StringBuilder();

            string reverted = string.Empty;


            for (int ch = toBeReverted.Length - 1; ch >= 0; ch--)
            {
                revertedSB.Append(toBeReverted[ch]);
            }


            reverted = revertedSB.ToString();

            Console.WriteLine(reverted);
        }
    }
}
