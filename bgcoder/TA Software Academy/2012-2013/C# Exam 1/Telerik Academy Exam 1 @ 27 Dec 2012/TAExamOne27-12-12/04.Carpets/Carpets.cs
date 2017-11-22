using System;

class Carpets
{
    static void Main(string[] args)
    {
        int n = 116; //int.Parse(Console.ReadLine());
        char[][] carpet = new char[n][];
        for (int i = 0; i < n; i++)
        {
            carpet[i] = new char[n];
            for (int k = 0; k < n; k++)
            {
                carpet[i][k] = '.';
            }
        }

        char symOne = new char();
        char symTwo = new char();

        for (int up = 0, down = n; up < n / 2; up++, down--)
        {
            if (up % 2 == 1)
            {
                symOne = ' ';
                symTwo = ' ';
            }
            else
            {
                symOne = '/';
                symTwo = '\u005c';
            }

            for (int heigth = up, left = (n / 2) - 1, right = n / 2; heigth < down; heigth++)
            {

                if (heigth < (n / 2))
                {
                    for (int l = left; l <= right; l += right - left)
                    {

                        if (l < (n / 2))
                        {
                            carpet[heigth][l] = symOne;
                        }
                        else
                        {
                            carpet[heigth][l] = symTwo;
                        }
                    }

                    if (heigth == ((n / 2) - 1))
                    {
                        continue;
                    }

                    left--;
                    right++;
                }
                else
                {
                    for (int l = left; l <= right; l += right - left)
                    {

                        if (l < (n / 2))
                        {
                            carpet[heigth][l] = symTwo;
                        }
                        else
                        {
                            carpet[heigth][l] = symOne;
                        }
                    }

                    left++;
                    right--;
                }
            }
        }



        for (int i = 0; i < n; i++)
        {
            foreach (var item in carpet[i])
            {
                Console.Write(item);
            }
            Console.WriteLine();
        }
    }
}

