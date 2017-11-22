using System;

class OnesAndZeros
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        char[][] binPicture = new char[5][];
        for (int row = 0; row < 5; row++)
        {
            int controllDots = 1;
            bool placeDot = false;
            if ((row == 0) || (row == 4))
            {
                controllDots = 3;
            }

            binPicture[row] = new char[63];
            for (int col = 0, controller = 0; col < 63; col++)
            {
                if (controller < controllDots)
                {
                    placeDot = false;
                    controller++;
                }
                else
                {
                    placeDot = true;
                    controller = 0;
                }

                if (placeDot)
                {
                    binPicture[row][col] = '.';
                }
                else
                {
                    binPicture[row][col] = '#';
                }
            }
        } // Binary Picture Of 0

        string nInBin = Convert.ToString(n, 2);
        if (nInBin.Length <= 16)
        {
            nInBin = nInBin.PadLeft(16, '0');
        }
        else
        {
            string newNum = "";
            nInBin = nInBin.PadLeft(32, '0');

            for (int i = 16; i < nInBin.Length; i++)
            {
                newNum += nInBin[i].ToString();
            }
            nInBin = newNum;
        } // Get Last 16 bits Of N In String

        //Console.WriteLine(nInBin);

        for (int bit = 0, controller = 0; bit < 16; bit++, controller += 4)
        {
            if (nInBin[bit] == '1')
            {
                for (int row = 0; row < 5; row++)
                {
                    bool placeDot = true;
                    if ((row == 1) || (row == 4))
                    {
                        placeDot = false;
                    }
                    for (int col = controller; col < controller + 3; col++)
                    {
                        if (placeDot)
                        {
                            binPicture[row][col] = '.';
                            placeDot = false;
                        }
                        else
                        {
                            binPicture[row][col] = '#';
                            if (!(((row == 1) && (col == controller)) || ( ((row == 4) && (col == controller)) || ((row == 4) && (col == controller + 1)) ) ))
                            {
                                placeDot = true;
                            }
                        }
                    }
                }
            }
        } // Do the Magic!

        for (int i = 0; i < 5; i++)
        {
            foreach (var item in binPicture[i])
            {
                Console.Write(item);
            }
            Console.WriteLine();
        } // Print
    }
}

