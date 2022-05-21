using System;

namespace Ex02
{
    class Program
    {
        static void Main(string[] args)
        {
            Random numAleatorio = new Random();
            int valorSorteado = numAleatorio.Next(1, 10);
            int limite = 11;

            //Console.WriteLine($"{valorSorteado}");

            int valorRequisitado = 0;
            Random provocacaoAleatoria = new Random();
            int idProvocacao = 0;



            string[] provocacao = new string[] { "Frangolino", "Frangão", "Verme" };
            idProvocacao = SortearProvocacao(idProvocacao);














            // --------------------------------------------------------------------------------------


            Console.WriteLine($"\n Digite um numero de 1 a 10, se você acertar você vence!");
            Console.WriteLine($"\n Aperte ZeR0 para desistir {provocacao[idProvocacao]}!");

            valorRequisitado = RequisitarNumero(valorRequisitado);
            Console.WriteLine($"{valorRequisitado}");

            if (valorRequisitado! > 0 && valorRequisitado != valorSorteado)
            {
                do
                {
                    if (valorRequisitado >= limite)
                    {
                        Console.WriteLine($"\n Eu disse, DIGITE UM NUMERO DE 1 A 10 {provocacao[idProvocacao]}");
                        Console.WriteLine($"\n Aperte ZeR0 para desistir {provocacao[idProvocacao]}!");
                        valorRequisitado = RequisitarNumero(valorRequisitado);
                        Console.WriteLine($"{valorRequisitado}");
                    }


                    else
                    {
                        idProvocacao = SortearProvocacao(idProvocacao);

                        Console.WriteLine($"\n Digite um numero de 1 a 10, se você acertar você vence!");
                        Console.WriteLine($"\n Aperte ZeR0 para desistir {provocacao[idProvocacao]}!");

                        valorRequisitado = RequisitarNumero(valorRequisitado);
                        Console.WriteLine($"{valorRequisitado}");
                    }
                }
                while (valorRequisitado != 0 && valorRequisitado != valorSorteado);
                Sair();
            }
            Sair();


            // --------------------------------------------------------------------------------------


        }
        static void Sair()
        {
            System.Environment.Exit(0);
        }


        static int RequisitarNumero(int valorRequisitado)
        {
            Console.Write("Digite um numero: ");

            valorRequisitado = Convert.ToInt32(Console.ReadLine());

            return (valorRequisitado);
        }

        static int SortearProvocacao(int idProvocacao)
        {

            Random provocacaoAleatoria = new Random();
            idProvocacao = provocacaoAleatoria.Next(0, 2);

            return (idProvocacao);
        }





    }





}
