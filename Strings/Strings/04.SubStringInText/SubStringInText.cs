using System;

class SubStringInText
{
    static void Main(string[] args)
    {
        string pattern = Console.ReadLine();
        string text = Console.ReadLine();
        int matchings = 0;

        for (int index = 0; index < text.Length - (pattern.Length - 1); index++)
        {
            string pieceOfText = text.Substring(index, pattern.Length);
            if (pattern.Equals(pieceOfText, StringComparison.CurrentCultureIgnoreCase))
            {
                matchings++;
            }
        }

        Console.WriteLine(matchings);
    }
}

