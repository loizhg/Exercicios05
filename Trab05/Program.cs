using System;

namespace Ex03
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[3];




            for (int p = 0; p < numeros.Length; p++)
            {
                Console.Write("Digite um numero: ");
                numeros[p] = Convert.ToInt32(Console.ReadLine());
            }

            int contador1 = numeros[0];
            int[] divisiveis1 = new int[contador1];
            int contador2 = numeros[1];
            int[] divisiveis2 = new int[contador2];
            int contador3 = numeros[2];
            int[] divisiveis3 = new int[contador3];





            //CHECAR TODOS DIVISIVEIS ...
            ChecarDivisiveis1(numeros, divisiveis1);
            ChecarDivisiveis2(numeros, divisiveis2);
            ChecarDivisiveis3(numeros, divisiveis3);




            //escrever os divisiveis 
            // ------------------------------------------------------------------------------------
            // ------------------------------------------------------------------------------------
            Console.Write($"Divisives de: {numeros[0]} ");
            for (int p = 0; p < divisiveis1.Length; p++)
            {
                if (divisiveis1[p] > 0)
                {
                    Console.WriteLine($"{divisiveis1[p]}");
                }
            }

            Console.Write($"Divisives de: {numeros[1]} ");
            for (int p = 0; p < divisiveis2.Length; p++)
            {
                if (divisiveis2[p] > 0)
                {
                    Console.WriteLine($"{divisiveis2[p]}");
                }
            }

            Console.Write($"Divisives de: {numeros[2]} ");
            for (int p = 0; p < divisiveis3.Length; p++)
            {
                if (divisiveis3[p] > 0)
                {
                    Console.WriteLine($"{divisiveis3[p]}");
                }
            }

            //ESCREVER O MDC
            ChecarMDC(divisiveis1, divisiveis2, divisiveis3);

        }
        static int[] ChecarDivisiveis1(int[] numeros, int[] divisiveis1)
        {
            for (int i = 1; i < numeros[0]; i++)
            {


                if (numeros[0] % i == 0)
                {
                    divisiveis1[i] = i;
                }

            }

            return divisiveis1;
        }

        static int[] ChecarDivisiveis2(int[] numeros, int[] divisiveis2)
        {
            for (int i = 1; i < numeros[1]; i++)
            {



                if (numeros[1] % i == 0)
                {
                    divisiveis2[i] = i;
                }

            }

            return divisiveis2;
        }

        static int[] ChecarDivisiveis3(int[] numeros, int[] divisiveis3)
        {
            for (int i = 1; i < numeros[2]; i++)
            {


                if (numeros[2] % i == 0)
                {
                    divisiveis3[i] = i;
                }

            }

            return divisiveis3;
        }

        static int[] ChecarMDC(int[] divisiveis1, int[] divisiveis2, int[] divisiveis3)
        {
            int divisorMaximo1 = 0;
            int divisorMaximo2 = 0;
            int divisorMaximo3 = 0;





            for (int a = 0; a < divisiveis1.Length; a++)
            {
                for (int b = 0; b < divisiveis2.Length; b++)
                {
                    if (divisiveis1[a] == divisiveis2[b])
                    {
                        divisorMaximo1 = divisiveis1[a];
                        divisorMaximo2 = divisiveis2[b];
                    }


                }

            }



            Console.Write($"Dvisor maximo 1: {divisorMaximo1}");
            Console.Write($"Dvisor maximo 2: {divisorMaximo2}");
            Console.Write($"Dvisor maximo 3: {divisorMaximo3}");
            return divisiveis3;
        }




    }

}
