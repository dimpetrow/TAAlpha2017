using System;
using System.Text;

class StringLength
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();

        if (input.Length < 20)
        {
            StringBuilder formatedInput = new StringBuilder();
            formatedInput.Append(input);

            for (int i = input.Length; i < 20; i++)
            {
                formatedInput.Append("*");
            }

            Console.WriteLine(formatedInput.ToString());
        }
        else
        {
            Console.WriteLine(input);
        }
    }
}
