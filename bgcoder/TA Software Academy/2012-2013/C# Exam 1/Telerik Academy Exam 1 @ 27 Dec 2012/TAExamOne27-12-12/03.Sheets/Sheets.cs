using System;

class Sheets
{
    static void Main(string[] args)
    {
        int n = 100;//int.Parse(Console.ReadLine());
        string nStr = Convert.ToString(n, 2);
        nStr = nStr.PadLeft(11, '0');
        char[] sheetA = new char[11];
        string[] sheets = new string[11];
        for (int i = 10, pows = 0; i >= 0; i--, pows++)
        {
            sheetA[i] = '1';
            sheets[i] = "A" + i;
        }

        for (int i = 0; i < 11; i++)
        {
            if (sheetA[i] == nStr[i])
            {
                sheets[i] = null;
            }
        }

        for (int i = 0; i < 11; i++)
        {
            if (sheets[i] != null)
            {
                Console.WriteLine(sheets[i]);
            }
        }
    }
}