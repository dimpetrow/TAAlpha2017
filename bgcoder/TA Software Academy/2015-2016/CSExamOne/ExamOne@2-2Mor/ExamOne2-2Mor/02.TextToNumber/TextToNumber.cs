using System;

class TextToNumber
{
    static void Main(string[] args)
    {
        int m = 2222;//int.Parse(Console.ReadLine());
        string text = "Starwars 4, 5 and 6 are better that 1, 2 and 3@";//Console.ReadLine();
        int result = 0;

        for (int i = 0; i < text.Length; i++)
        {
            if (text[i] == '@')
            {
                Console.WriteLine(result);
                break;
            }
            else if ((text[i] >= 48) && (text[i] <= 57))
            {
                result *= text[i] - 48;
            }
            else if ((text[i] >= 97) && (text[i] <= 122))
            {
                result += text[i] - 97;
            }
            else if ((text[i] >= 65) && (text[i] <= 90))
            {
                result += text[i] - 65;
            }
            else
            {
                result %= m;
            }
        }
    }
}

