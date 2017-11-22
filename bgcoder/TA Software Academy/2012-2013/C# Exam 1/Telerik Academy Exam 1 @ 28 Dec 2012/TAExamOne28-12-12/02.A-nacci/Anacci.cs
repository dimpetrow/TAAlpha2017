using System;

class Anacci
{
    static void Main(string[] args)
    {
        char aOne = 'A';// char.Parse(Console.ReadLine());
        char aTwo = 'Q';// char.Parse(Console.ReadLine());
        char aNth = new char();
        int l = 1;// int.Parse(Console.ReadLine());
        int n = 1;
        for (int i = 1; i < l; i++)
        {
            n += 2;
        }
        char[] aSec = new char[n];

        if (n == 1)
        {
            Console.WriteLine(aOne);
        }
        else
        {
            aSec[0] = aOne;
            aSec[1] = aTwo;
            for (int i = 2; i < n; i++)
            {
                if (((aOne - 64) + (aTwo - 64)) <= 26)
                {
                    aNth = (char)(((aOne - 64) + (aTwo - 64)) + 64);
                }
                else
                {
                    aNth = (char)((((aOne - 64) + (aTwo - 64)) % 26) + 64);
                }

                aSec[i] = aNth;
                aOne = aTwo;
                aTwo = aNth;
            }

            Console.WriteLine(aSec[0]);
            for (int line = 1, ind = 1, wSpace = 0; line < l; line++, wSpace++)
            {
                Console.Write(aSec[ind++]);
                for (int k = 0; k < wSpace; k++)
                {
                    Console.Write(" ");
                }
                Console.Write(aSec[ind++]);
                Console.WriteLine();
            }
        }
    }
}
