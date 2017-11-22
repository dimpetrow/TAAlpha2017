using System;

class BatGoikoTower
{
    static void Main(string[] args)
    {
        int h = 11;//int.Parse(Console.ReadLine());
        char[][] model = new char[h][];
        for (int i = 0; i < h; i++)
        {
            model[i] = new char[h * 2];
            for (int k = 0; k < h * 2; k++)
            {
                model[i][k] = '.';
            }
        }

        for (int ver = 0, crossbeam = 1, nextCrossbeam = 2, start = h - 1, end = h, crossStart = h - 1, crossEnd = h,nextCross = 2; ver < h; ver++, start--, end++)
        {
            for (int hor = start; hor <= end; hor += (end - start))
            {
                if (hor < h)
                {
                    model[ver][hor] = '/';
                }
                else
                {
                    model[ver][hor] = '\\';
                }
            }

            if (ver == crossbeam)
            {
                crossbeam += nextCrossbeam;
                nextCrossbeam++;

                for (int hor = crossStart; hor <= crossEnd; hor++)
                {
                    model[ver][hor] = '-';
                }

                crossStart -= nextCross;
                crossEnd += nextCross;
                nextCross++;
            }
        }

        for (int i = 0; i < h; i++)
        {
            foreach (var item in model[i])
            {
                Console.Write(item);
            }
            Console.WriteLine();
        }
    }
}

