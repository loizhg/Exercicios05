using System;
using System.Collections;
namespace SortingExample
{
    class Program
    {
        static void Main(string[] args)
        {


            decimal valor;


            Console.WriteLine($"Digite um valor: ");
            valor = Convert.ToDecimal(Console.ReadLine());




            int contador = Convert.ToInt32(valor);
            decimal[] divisiveis = new decimal[contador];


            int contadorDivisiveis = 0;

            for (int i = 1; i < valor; i++)
            {

                decimal valorDividido = valor / i;



                if (valorDividido % 2 == 0)
                {
                    divisiveis[i] = i;
                    contadorDivisiveis++;
                    Console.WriteLine($"{divisiveis[i]}");
                }


            }



            for (int i = 1; i < divisiveis.Length; i++)
            {
                divisiveis = ChecarDivisiveis(valor, divisiveis);
                if (divisiveis[i] > 0)
                {
                    Console.Write($"{divisiveis[i]}");
                }
                else
                {
                    Console.Write($"");

                }
            }

        }


        static void Sair()
        {
            System.Environment.Exit(0);
        }

        static decimal[] ChecarDivisiveis(decimal valor, decimal[] divisiveis)
        {
            for (int i = 1; i < valor; i++)
            {

                decimal valorDividido = valor / i;

                if (valorDividido % 2 == 0)
                {
                    divisiveis[i] = i;
                }

            }

            return divisiveis;
        }









    }
}