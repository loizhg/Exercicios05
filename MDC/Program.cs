using System;

namespace Ex04._02
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = 50;
            int n2 = 60;
            int n3 = 30;
            int contadorN1 = n1;
            int contadorN2 = n2;
            int contadorN3 = n3;
            int[] diviseiveisN1 = new int[contadorN1];
            int[] diviseiveisN2 = new int[contadorN2];
            int[] diviseiveisN3 = new int[contadorN3];

            int contadorDVn1 = 0;
            int contadorDVn2 = 0;
            int contadorDVn3 = 0;


            int contador = 1;






            int divisor = 2;

            do
            {
                Console.WriteLine($"Divisor {divisor}");

                if (n1 % divisor == 0)
                {
                    Console.WriteLine($"Numero {n1}");
                    n1 = (n1 / divisor);
                    Console.WriteLine($"{n1}");
                    diviseiveisN1[contador] = divisor;


                }
                if (n2 % divisor == 0)
                {
                    Console.WriteLine($"Numero {n2}");
                    n2 = (n2 / divisor);
                    Console.WriteLine($"{n2}");
                    diviseiveisN2[contador] = divisor;


                }
                if (n3 % divisor == 0)
                {
                    Console.WriteLine($"Numero {n3}");
                    n3 = (n3 / divisor);
                    Console.WriteLine($"{n3}");
                    diviseiveisN3[contador] = divisor;


                }
                else
                {
                    contador++;
                    divisor++;
                }

                Console.WriteLine($"CONTADOR {contador}");


            } while (n1 != 1 && n2 != 1 && n3 != 1);
            divisor = 2;


            int[] arrayMDC = new int[contador];


            for (int i = 0; i < diviseiveisN1.Length; i++)
            {


                Console.WriteLine($"CONTADOR {diviseiveisN1[i]}");
            }




        }





    }
}
