using System;

class NaBabaMiSmetalnika
{
    static void Main(string[] args)
    {
        int width = 25;//int.Parse(Console.ReadLine());
        int[] topchenca = { 1546, 15234, 14, 52343, 240, 23429, 172342, 85234 };//new int[8];
        //for (int i = 0; i < 8; i++)
        //{
        //    topchenca[i] = int.Parse(Console.ReadLine());
        //}

        char[][] smetalnik = new char[8][];
        for (int line = 0; line < 8; line++)
        {
            string red = Convert.ToString(topchenca[line], 2);
            red = red.PadLeft(width, '0');

            smetalnik[line] = new char[width];
            for (int col = 0; col < width; col++)
            {
                smetalnik[line][col] = red[col];
            }
        }

        for (int i = 0; i < 8; i++)
        {
            foreach (var item in smetalnik[i])
            {
                Console.Write(item);
            }
            Console.WriteLine();
        }

        while (true)
        {
            string comanda = Console.ReadLine();
            int linePrust = new int();
            int colPrust = new int();
            if (comanda == "stop")
            {
                break;
            }
            else if (comanda != "reset")
            {
                linePrust = int.Parse(Console.ReadLine());
                colPrust = int.Parse(Console.ReadLine());
                if ((colPrust < 0) || (colPrust > width - 1))
                {
                    continue;
                }
            }

            switch (comanda)
            {
                case "right":
                    int topchencaCount = 0;
                    for (int start = colPrust; start < width; start++)
                    {
                        if (smetalnik[linePrust][start] == '1')
                        {
                            topchencaCount++;
                            smetalnik[linePrust][start] = '0';
                        }
                    }

                    for (int i = 0, start = width - 1; i < topchencaCount; i++, start--)
                    {
                        smetalnik[linePrust][start] = '1';
                    }
                    break;
                case "left":
                    topchencaCount = 0;
                    for (int start = colPrust; start >= 0; start--)
                    {
                        if (smetalnik[linePrust][start] == '1')
                        {
                            topchencaCount++;
                            smetalnik[linePrust][start] = '0';
                        }
                    }

                    for (int i = 0, start = 0; i < topchencaCount; i++, start++)
                    {
                        smetalnik[linePrust][start] = '1';
                    }
                    break;
                case "reset":
                    topchencaCount = 0;
                    for (int line = 0; line < 8; line++)
                    {
                        for (int col = 0; col < width; col++)
                        {
                            if (smetalnik[line][col] == '1')
                            {
                                topchencaCount++;
                                smetalnik[line][col] = '0';
                            }
                        }

                        for (int col = 0; col < topchencaCount; col++)
                        {
                            smetalnik[line][col] = '1';
                        }

                        topchencaCount = 0;
                    }
                    break;

                default:
                    break;
            }
        }

        for (int i = 0; i < 8; i++)
        {
            foreach (var item in smetalnik[i])
            {
                Console.Write(item);
            }
            Console.WriteLine();
        }

        int sum = 0;

        for (int line = 0; line < 8; line++)
        {
            int emptyCols = 0;
            int num = 0;
            for (int col = width - 1, pow = 0; col >= 0; col--,pow++)
            {
                if (smetalnik[line][col] == '1')
                {
                    num += (int)Math.Pow(2, pow);
                }
                else
                {
                    emptyCols++;
                }
            }
            num *= emptyCols;
            sum += num;
        }

        Console.WriteLine(sum);
    }
}

