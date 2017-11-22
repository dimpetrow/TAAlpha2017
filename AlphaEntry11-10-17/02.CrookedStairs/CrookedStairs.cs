using System;

class CrookedStairs
{
    static void Main(string[] args)
    {
        long bOne = long.Parse(Console.ReadLine());
        long bTwo = long.Parse(Console.ReadLine());
        long bThree = long.Parse(Console.ReadLine());
        int lines = int.Parse(Console.ReadLine());

        long bNth;

        Console.WriteLine(bOne);
        Console.WriteLine(bTwo + " " + bThree);

        for (int line = 2, bricks = 3; line < lines; line++, bricks++)
        {
            long[] brickLine = new long[bricks];

            for (int br = 0; br < bricks; br++)
            {
                bNth = bOne + bTwo + bThree;

                brickLine[br] = bNth;

                bOne = bTwo;
                bTwo = bThree;
                bThree = bNth;
            }

            Console.WriteLine(string.Join(" ", brickLine));
        }
    }
}

