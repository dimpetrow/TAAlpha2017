using System;

class CoffeeMachine
{
    static void Main(string[] args)
    {
        int[] coinTrays = { 4, 5, 4, 2, 1 };//new int[5];
        //for (int i = 0; i < 5; i++)
        //{
        //    coinTrays[i] = int.Parse(Console.ReadLine());
        //}
        double amountPut = 10.00;//double.Parse(Console.ReadLine());
        double price = 2.00;//double.Parse(Console.ReadLine());

        double sumOfCoinsInMachine = (coinTrays[0] * 0.05) + (coinTrays[1] * 0.10) + (coinTrays[2] * 0.20) + (coinTrays[3] * 0.50) + (coinTrays[4] * 1.00);


        if (amountPut >= price)
        {
            double change = amountPut - price;

            if (sumOfCoinsInMachine >= change)
            {
                Console.WriteLine("Yes {0:f2}", (sumOfCoinsInMachine - change));
            }
            else if (sumOfCoinsInMachine < change)
            {
                Console.WriteLine("No {0:f2}", (change - sumOfCoinsInMachine));
            }
        }
        else if (amountPut < price)
        {
            Console.WriteLine("More {0:f2}", (price - amountPut));
        }
    }
}

