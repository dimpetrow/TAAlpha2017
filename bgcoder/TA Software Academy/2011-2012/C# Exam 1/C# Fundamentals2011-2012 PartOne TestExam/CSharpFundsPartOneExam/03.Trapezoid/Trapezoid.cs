using System;

class Trapezoid
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int widthTop = n;
        int widthBottom = n * 2;
        int height = n + 1;

        int perimeter = widthBottom + widthTop + (height + height);

        int areaWidth = n * 2;
        int areaHeight = n + 1;

        int horizontal = n;
        int vertical = 0;

        string[][] areaCopy = new string[areaHeight][];
        for (int i = 0; i < areaHeight; i++)
        {
            areaCopy[i] = new string[areaWidth];
            for (int k = 0; k < areaWidth; k++)
            {
                areaCopy[i][k] = ".";
            }
        }

        for (int i = 0,leftHip = 0; i < perimeter; i++)
        {
            areaCopy[vertical][horizontal] = "*";
            
            if ((horizontal < areaWidth - 1) && (vertical == 0))
            {
                horizontal++;
            }
            else if ((vertical < areaHeight - 1) && (horizontal == areaWidth - 1))
            {
                vertical++;
            }
            else if ((horizontal > 0) && (vertical == areaHeight - 1))
            {
                horizontal--;
            }
            else if ((vertical > 0) && (horizontal == leftHip))
            {
                vertical--;
                horizontal++;
                leftHip++;
            }
        }

        for (int i = 0; i < areaHeight; i++)
        {
            foreach (var item in areaCopy[i])
            {
                Console.Write(item);
            }
            Console.WriteLine();
        }
    }
}

