using System;

namespace mmc
{
    class Program
    {
        static void Main(string[] args)
        {

            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            int num3 = Convert.ToInt32(Console.ReadLine());




            int resto;

            int a = num1;
            int b = num2;
            int c = num3;

            do
            {
                resto = a % b;

                a = b;
                b = resto;

            } while (resto != 0);

            int mmc = (num1 * num2) / a;

            Console.WriteLine($"{mmc}");


        }



    }
}