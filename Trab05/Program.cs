﻿using System;

namespace Ex04._02
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = 50;
            int n2 = 60;
            int n3 = 30;


            int divisor = 2;

            do
            {
                if (n1 % divisor == 0)
                {
                    Console.WriteLine($"Numero {n1}");
                    Console.WriteLine($"Divisor {divisor}");
                    n1 = (n1 / divisor);
                    Console.WriteLine($"{n1}");
                }
                else if (n2 % divisor == 0)
                {
                    Console.WriteLine($"Numero {n2}");
                    Console.WriteLine($"Divisor {divisor}");
                    n2 = (n2 / divisor);
                    Console.WriteLine($"{n2}");
                }
                else if (n3 % divisor == 0)
                {
                    Console.WriteLine($"Numero {n3}");
                    Console.WriteLine($"Divisor {divisor}");
                    n3 = (n3 / divisor);
                    Console.WriteLine($"{n3}");
                }
                else
                {
                    divisor++;
                }
            } while (n1 != 1 && n2 != 1 && n3 != 1);
            divisor = 2;



            


        }





    }
}
