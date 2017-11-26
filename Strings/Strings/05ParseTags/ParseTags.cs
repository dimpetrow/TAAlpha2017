using System;
using System.Text;

class ParseTags
{
    static void Main(string[] args)
    {
        string text = Console.ReadLine();
        StringBuilder texWithUpper = new StringBuilder();

        bool upperCase = false;
        string checkerForTags = string.Empty;
        for (int index = 0; index < text.Length; index++)
        {
            if (text[index] == '<')
            {
                index++;
                if (index < text.Length - 7 && text.Substring(index, 7) == "upcase>")
                {
                    index += 6;
                    upperCase = true;
                    continue;
                }
                else if (index < text.Length - 7 && text.Substring(index, 8) == "/upcase>")
                {
                    index += 7;
                    upperCase = false;
                    continue;
                }
            }

            if (upperCase)
            {
                texWithUpper.Append(text[index].ToString().ToUpper());
            }
            else
            {
                texWithUpper.Append(text[index].ToString());
            }
        }

        Console.WriteLine(texWithUpper.ToString());
    }
}


