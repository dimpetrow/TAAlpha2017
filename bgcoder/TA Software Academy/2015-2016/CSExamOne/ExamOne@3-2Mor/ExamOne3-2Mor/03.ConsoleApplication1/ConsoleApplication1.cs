using System;
using System.Numerics;

class ConsoleApplication1
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        string numberStr = input;
        BigInteger firstTenProd = 1;
        BigInteger productOfTheRest = 1;

        while (true)
        {
            input = Console.ReadLine();
            if (input == "END")
            {
                break;
            }
            numberStr += " " + input;
        }

        string[] nums = numberStr.Split(' ');

        bool afterTenth = false;
        for (int num = 1; num < nums.Length; num += 2)
        {
            BigInteger digitsProduct = 1;
            if (!((nums[num].Length == 1) && (nums[num][0] == '0')))
            {
                for (int digit = 0; digit < nums[num].Length; digit++)
                {
                    if (nums[num][digit] == '0')
                    {
                        continue;
                    }
                    digitsProduct *= BigInteger.Parse(nums[num][digit].ToString());
                }
            }
            

            if (num > 10)
            {
                afterTenth = true;
            }

            if (afterTenth)
            {
                productOfTheRest *= digitsProduct;
            }
            else
            {
                firstTenProd *= digitsProduct;
            }
        }

        Console.WriteLine(firstTenProd);
        if (productOfTheRest != 1)
        {
            Console.WriteLine(productOfTheRest);
        }
    }
}

