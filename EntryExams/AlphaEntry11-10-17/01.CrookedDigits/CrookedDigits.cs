using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.CrookedDigits
{
    class CrookedDigits
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            int sum;

            do
            {
                sum = 0;

                for (int i = 0; i < number.Length; i++)
                {
                    if (number[i] != '-' && number[i] != '.')
                    {
                        sum += int.Parse(number[i].ToString());
                    }
                }

                number = sum.ToString();
            } while (number.Length != 1);

            Console.WriteLine(number);
        }
    }
}
