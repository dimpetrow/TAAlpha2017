using System;
using System.Text;

class ExtractSentences
{
    static void Main(string[] args)
    {
        string word = Console.ReadLine();
        string text = Console.ReadLine();

        string[] sentences = text.Split(new string[] { ". ", ".", "..." }, StringSplitOptions.RemoveEmptyEntries);
        
        StringBuilder words = new StringBuilder();
        

        bool wordFound = false;
        bool firstSent = true;

        for (int ch = 0, sent = 0; ch < text.Length; ch++)
        {
            if (!wordFound && ((text[ch] >= 65 && text[ch] <= 90) || (text[ch] >= 97 && text[ch] <= 122)))
            {
                words.Append(text[ch]);
            }
            else if (word == words.ToString())
            {
                wordFound = true;
                if (firstSent)
                {
                    Console.Write(sentences[sent] + ".");
                    firstSent = false;
                }
                else
                {
                    Console.Write(" " + sentences[sent] + ".");
                }
                words.Remove(0, words.Length);
            }
            else
            {
                words.Remove(0, words.Length);
            }
            
            if (text[ch] == '.')
            {
                sent++;
                wordFound = false;
            }
        }

        //string[] sentences = text.Split(new char[] { '.' }, StringSplitOptions.RemoveEmptyEntries);

        //for (int sent = 0; sent < sentences.Length; sent++)
        //{
        //    char[] separators = new char[] { ' ', ',', ':', ';', (char)34, (char)39 };
        //    string[] words = sentences[sent].Split(separators, StringSplitOptions.RemoveEmptyEntries);

        //    for (int w = 0; w < words.Length; w++)
        //    {
        //        if (word == words[w])
        //        {
        //            Console.Write(sentences[sent] + ".");
        //        }
        //    }
        //}
    }
}

