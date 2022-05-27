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

            int contador1 = n1;
            int contador2 = n2;
            int contador3 = n3;

            int[] divisiveis1 = new int[contador1];
            int[] divisiveis2 = new int[contador2];
            int[] divisiveis3 = new int[contador3];

            ChecarDivisiveis1(n1, divisiveis1, contador1);

            int contadorInteiros1 = 0;
            int contadorInteiros2 = 0;
            int contadorInteiros3 = 0;


            Console.WriteLine($"N 1: {n1}");


            for (int i = 0; i < divisiveis1.Length; i++)
            {
                Console.WriteLine($"divisivel no slot: {i}");
                Console.WriteLine($"{divisiveis1[i]}");
            }

            contadorInteiros1 = ChecarContadorInteiros1(n1, divisiveis1, contadorInteiros1);
            Console.WriteLine($"contador de inteiros: {contadorInteiros1}");

            int[] divisiveisInteiros1 = new int[contadorInteiros1];
            int[] divisiveisInteiros2 = new int[contadorInteiros1];
            int[] divisiveisInteiros3 = new int[contadorInteiros1];

            AtribuirValores1(divisiveis1, divisiveisInteiros1, contadorInteiros1);

            for (int i = 0; i < divisiveisInteiros1.Length; i++)
            {
                Console.WriteLine($"divisivel no slot: {i}");
                Console.WriteLine($"{divisiveisInteiros1[i]}");
            }

        }

        static int[] ChecarDivisiveis1(int n1, int[] divisiveis1, int contadorInteiros1)
        {
            for (int i = 1; i < n1; i++)
            {
                if (n1 % i == 0)
                {
                    divisiveis1[i] = i;
                }

            }
            return divisiveis1;
        }

        static int ChecarContadorInteiros1(int n1, int[] divisiveis1, int contadorInteiros1)
        {
            for (int i = 1; i < n1; i++)
            {
                if (n1 % i == 0)
                {
                    divisiveis1[i] = i;
                    contadorInteiros1++;
                }

            }
            return contadorInteiros1;
        }

        static int[] AtribuirValores1(int[] divisiveis1, int[] divisiveisInteiros1, int contadorInteiros1)
        {
            for (int i = 0; i < contadorInteiros1; i++)
            {
                bool flag = false;
                int supp = 0;
                if (divisiveis1[i] > 0)
                {
                    Console.WriteLine($"Atribuir {divisiveis1[i]}");
                    supp = divisiveis1[i];
                    if (supp > 0)
                    {
                        flag = true;
                    }
                    else
                    {
                        flag = false;
                    };
                }
                if (flag)
                {
                    divisiveisInteiros1[i] = divisiveis1[i];
                    flag = false;
                }

            }
            return divisiveisInteiros1;
        }


        static int[] ChecarDivisiveis2(int n2, int[] divisiveis2)
        {
            for (int i = 1; i < n2; i++)
            {
                if (n2 % i == 0)
                {
                    divisiveis2[i] = i;
                }
            }
            return divisiveis2;
        }

        static int[] ChecarDivisiveis3(int n3, int[] divisiveis3)
        {
            for (int i = 1; i < n3; i++)
            {
                if (n3 % i == 0)
                {
                    divisiveis3[i] = i;
                }
            }
            return divisiveis3;
        }




    }
}
