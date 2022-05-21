using System;

namespace Ex03
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[3];

            int contador1 = numeros[0];
            int[] divisiveis1 = new int[contador1];
            int contador2 = numeros[1];
            int[] divisiveis2 = new int[contador2];
            int contador3 = numeros[2];
            int[] divisiveis3 = new int[contador3];


            for (int p = 0; p < numeros.Length; p++)
            {
                Console.Write("Digite um nome: ");
                numeros[p] = Convert.ToInt32(Console.ReadLine());
            }

            ChecarDivisiveis1(numeros, divisiveis1);
            ChecarDivisiveis2(numeros, divisiveis2);
            ChecarDivisiveis3(numeros, divisiveis3);



        }
        static int[] ChecarDivisiveis1(int[] numeros, int[] divisiveis1)
        {
            for (int i = 1; i < numeros[0]; i++)
            {

                decimal valorDividido = numeros[0] / i;

                if (valorDividido % 2 == 0)
                {
                    divisiveis1[i] = i;
                }

            }

            return divisiveis1;
        }

        static int[] ChecarDivisiveis2(int[] numeros, int[] divisiveis2)
        {
            for (int i = 1; i < numeros[0]; i++)
            {

                decimal valorDividido = numeros[0] / i;

                if (valorDividido % 2 == 0)
                {
                    divisiveis2[i] = i;
                }

            }

            return divisiveis2;
        }

        static int[] ChecarDivisiveis3(int[] numeros, int[] divisiveis3)
        {
            for (int i = 1; i < numeros[0]; i++)
            {

                decimal valorDividido = numeros[0] / i;

                if (valorDividido % 2 == 0)
                {
                    divisiveis3[i] = i;
                }

            }

            return divisiveis3;
        }



    }

}
