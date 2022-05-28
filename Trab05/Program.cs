using System;

namespace mmc
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 2;
            int n1sobra = Convert.ToInt32(Console.ReadLine());
            int n2sobra = Convert.ToInt32(Console.ReadLine()); ;
            int n3sobra = Convert.ToInt32(Console.ReadLine()); ;
            int acumulador = 1;

            while (n1sobra > 1 || n2sobra > 1 || n3sobra > 1)
            {
                if (n1sobra % i == 0 || n2sobra % i == 0 || n3sobra % i == 0)
                {

                    if (n1sobra % i == 0)
                        n1sobra = n1sobra / i;
                    if (n2sobra % i == 0)
                        n2sobra = n2sobra / i;
                    if (n3sobra % i == 0)
                        n3sobra = n3sobra / i;

                    acumulador *= i;

                }
                else
                {
                    i++;
                }
            }
            Console.WriteLine(acumulador);

        }
    }
}