using System;

class Enigmanation
{
    static void Main(string[] args)
    {
        string exp = "1*2*3*4*5*6*7*8*9%1-9=";//Console.ReadLine();
        int i = 1;
        double result = new double();
        if (!(exp[0] == '('))
        {
            result = double.Parse(exp[0].ToString());
        }
        else
        {
            i = -1;
        }

        for (; (i < exp.Length) && ((i == -1) || (exp[i] != '='));)
        {
            if (exp[i + 1] == '(')
            {
                double resInBrac = double.Parse(exp[i + 2].ToString());
                int k = i + 3;

                for (; (k < exp.Length) && (exp[k] != ')'); k += 2)
                {
                    switch (exp[k])
                    {
                        case '+':
                            resInBrac += double.Parse(exp[k + 1].ToString());
                            break;
                        case '-':
                            resInBrac -= double.Parse(exp[k + 1].ToString());
                            break;
                        case '*':
                            resInBrac *= double.Parse(exp[k + 1].ToString());
                            break;
                        case '%':
                            resInBrac %= double.Parse(exp[k + 1].ToString());
                            break;
                        default:
                            break;
                    }
                }

                if (i != -1)
                {
                    switch (exp[i])
                    {
                        case '+':
                            result += resInBrac;
                            break;
                        case '-':
                            result -= resInBrac;
                            break;
                        case '*':
                            result *= resInBrac;
                            break;
                        case '%':
                            result %= resInBrac;
                            break;
                        default:
                            break;
                    }
                }
                else
                {
                    result += resInBrac;
                }


                i = k + 1;
            }
            else
            {
                switch (exp[i])
                {
                    case '+':
                        result += double.Parse(exp[i + 1].ToString());
                        break;
                    case '-':
                        result -= double.Parse(exp[i + 1].ToString());
                        break;
                    case '*':
                        result *= double.Parse(exp[i + 1].ToString());
                        break;
                    case '%':
                        result %= double.Parse(exp[i + 1].ToString());
                        break;
                    default:
                        break;
                }

                i += 2;
            }
        }

        Console.WriteLine("{0:f3}", result);
    }
}

