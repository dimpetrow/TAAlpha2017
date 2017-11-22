using System;

class Garden
{
    static void Main(string[] args)
    {
        int[] vegAmount = { 10, 25, 42, 15, 18 };//new int[5];
        int[] vegArea = { 20, 30, 38, 23, 36 };//new int[5];
        //for (int i = 0,dispenser = 0; i < 5;)
        //{
        //    if (dispenser == 0)
        //    {
        //        vegAmount[i] = int.Parse(Console.ReadLine());
        //        dispenser = 1;
        //    }
        //    else
        //    {
        //        vegArea[i] = int.Parse(Console.ReadLine());
        //        dispenser = 0;
        //        i++;
        //    }
        //}
        double[] seedsCost = { 0.5, 0.4, 0.25, 0.6, 0.3, 0.4 };
        int beansAmount = 70;//int.Parse(Console.ReadLine());

        double totalCostOfAllSeeds = 0d;
        for (int i = 0; i < 5; i++)
        {
            totalCostOfAllSeeds += ((double)vegAmount[i] * seedsCost[i]);
        }
        totalCostOfAllSeeds += (beansAmount * seedsCost[5]);
        Console.WriteLine("Total costs: {0:f2}", totalCostOfAllSeeds);

        int totalArea = 0;
        for (int i = 0; i < 5; i++)
        {
            totalArea += vegArea[i];
        }

        if ((250 - totalArea) > 0)
        {
            Console.WriteLine("Beans area: {0}", (250 - totalArea));
        }
        else if ((250 - totalArea) == 0)
        {
            Console.WriteLine("No area for beans");
        }
        else
        {
            Console.WriteLine("Insufficient area");
        }
    }
}

