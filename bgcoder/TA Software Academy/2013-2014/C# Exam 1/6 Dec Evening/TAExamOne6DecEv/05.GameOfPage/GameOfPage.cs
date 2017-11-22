using System;

class GameOfPage
{
    static void Main(string[] args)
    {
        char[][] tray = new char[16][];
        tray[0] = "0000000000000111".ToCharArray();
        tray[1] = "0100000000000111".ToCharArray();
        tray[2] = "0000000000000111".ToCharArray();
        tray[3] = "0000000000000000".ToCharArray();
        tray[4] = "0000000000000000".ToCharArray();
        tray[5] = "0000111110000000".ToCharArray();
        tray[6] = "0000111110100000".ToCharArray();
        tray[7] = "0000111110000000".ToCharArray();
        tray[8] = "0000000000000000".ToCharArray();
        tray[9] = "0000000111000000".ToCharArray();
        tray[10] = "000001111000000".ToCharArray();
        tray[11] = "0000001110000000".ToCharArray();
        tray[12] = "0000001110000000".ToCharArray();
        tray[13] = "0000001110000000".ToCharArray();
        tray[14] = "0000001110000000".ToCharArray();
        tray[15] = "0000000000000000".ToCharArray();
        //for (int row = 0; row < 16; row++)
        //{
        //    string rowInput = Console.ReadLine();
        //    tray[row] = new char[16];
        //    for (int col = 0; col < 16; col++)
        //    {
        //        tray[row][col] = rowInput[col];
        //    }
        //}

        int posRow = new int();
        int posCol = new int();
        string question = "";
        double price = 0d;


        while (true)
        {
            question = Console.ReadLine();
            string whatIs = "";
            if (question == "paypal")
            {
                break;
            }
            posRow = int.Parse(Console.ReadLine());
            posCol = int.Parse(Console.ReadLine());
            int crumbs = 0;

            if (tray[posRow][posCol] == '1')
            {
                crumbs++;
                if ((posRow > 0) && (tray[posRow - 1][posCol] == '1'))
                {
                    crumbs++;
                }
                if ((posRow < 15) && (tray[posRow + 1][posCol] == '1'))
                {
                    crumbs++;
                }
                if ((posCol > 0) && (tray[posRow][posCol - 1] == '1'))
                {
                    crumbs++;
                }
                if ((posCol < 15) && (tray[posRow][posCol + 1] == '1'))
                {
                    crumbs++;
                }

                if (((posRow > 0) && (posCol > 0)) && (tray[posRow - 1][posCol - 1] == '1'))
                {
                    crumbs++;
                }
                if (((posRow > 0) && (posCol < 15)) && (tray[posRow - 1][posCol + 1] == '1'))
                {
                    crumbs++;
                }
                if (((posRow < 15) && (posCol < 15)) && (tray[posRow + 1][posCol + 1] == '1'))
                {
                    crumbs++;
                }
                if (((posRow < 15) && (posCol > 0)) && (tray[posRow + 1][posCol - 1] == '1'))
                {
                    crumbs++;
                }
            }

            if (crumbs == 1)
            {
                whatIs = "cookie crumb";
            }
            else if ((crumbs > 1) && (crumbs < 9))
            {
                whatIs = "broken cookie";
            }
            else if (crumbs == 9)
            {
                whatIs = "cookie";
            }
            else if (crumbs == 0)
            {
                whatIs = "smile";
            }

            switch (question)
            {
                case "what is":
                    Console.WriteLine(whatIs);
                    break;
                case "buy":
                    if (whatIs == "cookie")
                    {
                        price += 1.79d;
                        for (int r = posRow - 1; r < posRow + 2; r++)
                        {
                            for (int c = posCol - 1; c < posCol + 2; c++)
                            {
                                tray[r][c] = '0';
                            }
                        }
                    }
                    else if ((whatIs == "cookie crumb") || (whatIs == "broken cookie"))
                    {
                        Console.WriteLine("page");
                    }
                    else
                    {
                        Console.WriteLine("smile");
                    }
                    break;
                default:
                    break;
            }
        }

        Console.WriteLine("{0:f2}",price);
    }
}

