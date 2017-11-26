using System;
using System.Text;

class ReplaceTags
{
    static void Main(string[] args)
    {
        string htmlDoc = Console.ReadLine();
        StringBuilder textWOTags = new StringBuilder();
        StringBuilder urlAdress = new StringBuilder();
        StringBuilder siteName = new StringBuilder();


        bool isURL = false;
        bool isSiteName = false;
        for (int index = 0; index < htmlDoc.Length; index++)
        {
            if (htmlDoc[index] == '<')
            {
                if (index + 1 < htmlDoc.Length - 8 && htmlDoc.Substring(index + 1, 8) == "a href=\"")
                {
                    isURL = true;
                    index += 9;
                }
                else if (index + 1 < htmlDoc.Length - 3 && htmlDoc.Substring(index + 1, 3) == "/a>")
                {
                    textWOTags.Append("[" + siteName + "]");
                    textWOTags.Append("(" + urlAdress + ")");

                    siteName.Remove(0, siteName.Length);
                    urlAdress.Remove(0, urlAdress.Length);

                    isURL = false;
                    isSiteName = false;

                    index += 4;
                }
            }
            else if (htmlDoc[index] == '\"')
            {
                index++;
                if (index < htmlDoc.Length && htmlDoc[index] == '>')
                {
                    isSiteName = true;
                    index++;
                }
            }


            if (isURL)
            {
                if (isSiteName)
                {
                    siteName.Append(htmlDoc[index]);
                }
                else
                {
                    urlAdress.Append(htmlDoc[index]);
                }
            }
            else
            {
                textWOTags.Append(htmlDoc[index]);
            }
        }

        Console.WriteLine(textWOTags.ToString());
    }
}
