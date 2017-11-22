using System;

class QuadronacciRectangle
{
    static void Main(string[] args)
    {
        long qOne = 5;//long.Parse(Console.ReadLine());
        long qTwo = -5;//long.Parse(Console.ReadLine());
        long qThree = 1;//long.Parse(Console.ReadLine());
        long qFour = 2;//long.Parse(Console.ReadLine());
        long nThqNacci = new long();
        int rows = 2;//int.Parse(Console.ReadLine());
        int colls = 4;//int.Parse(Console.ReadLine());

        
        Console.Write(qOne + " ");
        Console.Write(qTwo + " ");
        Console.Write(qThree + " ");
        Console.Write(qFour + " ");

        for (int i = 0; i < rows; i++)
        {
            int k = 0;
            if ((i == 0) && (k < 4))
            {
                k = 4;
            }

            for (; k < colls; k++)
            {
                

                nThqNacci = qOne + qTwo + qThree + qFour;

                qOne = qTwo;
                qTwo = qThree;
                qThree = qFour;
                qFour = nThqNacci;

                Console.Write(nThqNacci + " ");
            }
            Console.WriteLine();
        }
    }
}

