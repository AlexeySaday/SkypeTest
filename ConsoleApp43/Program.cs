using System;
namespace ConsoleApp43
{
    class Program
    {
        private static double ConvertToDouble(string number)
        {
            double a = 1.0;

            if (number[0] == '-' || number[0] == '+')
            {
                int c;
                if (number[0] == '-') c = -1;
                else c = 1;
                if (Check(number[1]))
                {
                    a = number[1] - 48;
                    bool flag = true;
                    int i = 2;
                    while (i < number.Length && flag)
                    {
                        if (Check(number[i]))
                        {
                            a *= 10;
                            a += number[i] - 48;
                        }
                        else if (number[i] == '.' || number[i] == ',')
                        {
                            flag = false;
                        }
                        else throw new Exception(); 
                        i++;
                    }
                    double b = 1.0;
                    for (int j = i; j < number.Length; j++)
                    {
                        if (Check(number[j]))
                        {
                            b *= 0.1;
                            a += (number[j] - 48) * b;
                        }
                        else throw new Exception();  
                    }
                    return a * (c);
                }
                else throw new Exception(); 
            }
            else if (Check(number[0]))
            {
                a = number[0] - 48;
                bool flag = true;
                int i = 1;
                while (i < number.Length && flag)
                {
                    if (Check(number[i]))
                    {
                        a *= 10;
                        a += number[i] - 48;
                    }
                    else if (number[i] == '.' || number[i] == ',')
                    {
                        flag = false;
                    }
                    else throw new Exception(); 
                    i++;
                }
                double b = 1.0;
                for (int j = i; j < number.Length; j++)
                {
                    if (Check(number[j]))
                    {
                        b *= 0.1;
                        a += (number[j] - 48) * b;
                    }
                    else throw new Exception(); 
                }
                return a;
            }
            else throw new Exception(); 

        }
        static bool Check(char n)
        {
            string str = "0123456789";
            for (int j = 0; j < 10; j++)
                if (str[j] == n) return true;
            return false;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(ConvertToDouble("+1,0006"));    
        }
    }
}
