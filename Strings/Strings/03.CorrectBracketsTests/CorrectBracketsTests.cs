using System;

class CorrectBracketsTests
{
    static void Main(string[] args)
    {
        string expr = Console.ReadLine();
        int brackets = 0;
        
        for (int ch = 0; ch < expr.Length; ch++)
        {
            if (expr[ch] == '(')
            {
                brackets++;
            }
            else if (expr[ch] == ')')
            {
                brackets--;
            }
        }

        if (brackets == 0)
        {
            Console.WriteLine("Correct");
        }
        else
        {
            Console.WriteLine("Incorrect");
        }
    }
}

