using System;
using System.Collections;
namespace SortingExample
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] alunos = new string[10];
            alunos[0] = "Luiz";
            alunos[1] = "Tales";
            alunos[2] = "Collato";
            alunos[3] = "Yuske";
            alunos[4] = "Palu";
            alunos[5] = "Cris";
            alunos[6] = "Jhony";
            alunos[7] = "Naruto";
            alunos[8] = "Rock Lee";
            alunos[9] = "Sasuke";

            decimal[] notasA = new decimal[10];
            notasA[0] = 100;
            notasA[1] = 60;
            notasA[2] = 60;
            notasA[3] = 70;
            notasA[4] = 60;
            notasA[5] = 60;
            notasA[6] = 30;
            notasA[7] = 60;
            notasA[8] = 60;
            notasA[9] = 10;

            decimal[] notasB = new decimal[10];
            notasB[0] = 100;
            notasB[1] = 60;
            notasB[2] = 60;
            notasB[3] = 10;
            notasB[4] = 60;
            notasB[5] = 60;
            notasB[6] = 05;
            notasB[7] = 60;
            notasB[8] = 60;
            notasB[9] = 60;

            decimal[] notasC = new decimal[10];
            notasC[0] = 50;
            notasC[1] = 30;
            notasC[2] = 60;
            notasC[3] = 60;
            notasC[4] = 60;
            notasC[5] = 100;
            notasC[6] = 20;
            notasC[7] = 60;
            notasC[8] = 60;
            notasC[9] = 100;

            decimal[] media = new decimal[10];

            bool[] passou = new bool[10];
            passou[0] = false;
            passou[1] = false;
            passou[2] = false;
            passou[3] = false;
            passou[4] = false;
            passou[5] = false;
            passou[6] = false;
            passou[7] = false;
            passou[8] = false;
            passou[9] = false;

            decimal[] notaMaior = new decimal[10];
            decimal[] notaMenor = new decimal[10];

            decimal notaMediaMaior = 0;
            decimal notaMediaMenor = 0;

            decimal mediaGeral = 0;


            Console.WriteLine($"~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine($"~~~~CHECAR A MAIOR NOTA~~~~");
            Console.WriteLine($"~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            ChecarMaior(notaMaior, notasA, notasB, notasC);

            Console.WriteLine($"~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine($"~~~~CHECAR A MENOR NOTA~~~~");
            Console.WriteLine($"~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            ChecarMenor(notaMenor, notasA, notasB, notasC);

            Console.WriteLine($"~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine($"~CHECAR A MÉDIA INDIVIDUAL~");
            Console.WriteLine($"~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            ChecarMedia(media, notaMaior, notaMenor, alunos, passou);


            Console.WriteLine($"~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine($"~~~ CHECAR A MAIOR MÉDIA ~~");
            Console.WriteLine($"~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            ChecarMaiorMedia(media, notaMediaMaior, alunos);

            Console.WriteLine($"~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine($"~~~ CHECAR A MENOR MÉDIA ~~");
            Console.WriteLine($"~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            ChecarMenorMedia(media, notaMediaMenor, alunos);


            Console.WriteLine($"~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine($"~~~ CHECAR A MÉDIA GERAL ~~");
            Console.WriteLine($"~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            mediaGeral = ChecarMediaGeral(media, mediaGeral);
            Console.WriteLine($"A média geral da turma é: {mediaGeral} ");
        }


        static void Sair()
        {
            System.Environment.Exit(0);
        }

        static decimal[] ChecarMaior(decimal[] notaMaior, decimal[] notaA, decimal[] notaB, decimal[] notaC)
        {
            for (int i = 0; i < notaMaior.Length; i++)
            {
                if (notaA[i] > notaMaior[i])
                {
                    notaMaior[i] = notaA[i];
                }

                if (notaB[i] > notaMaior[i])
                {
                    notaMaior[i] = notaB[i];
                }

                if (notaC[i] > notaMaior[i])
                {
                    notaMaior[i] = notaC[i];
                }


            }

            return notaMaior;


        }

        static decimal[] ChecarMenor(decimal[] notaMenor, decimal[] notaA, decimal[] notaB, decimal[] notaC)
        {
            for (int i = 0; i < notaMenor.Length; i++)
            {

                notaMenor[i] = notaA[i];


                if (notaB[i] < notaMenor[i])
                {
                    notaMenor[i] = notaB[i];
                }

                if (notaC[i] < notaMenor[i])
                {
                    notaMenor[i] = notaC[i];
                }


            }
            return notaMenor;
        }

        static decimal[] ChecarMedia(decimal[] media, decimal[] notaMaior, decimal[] notaMenor, string[] alunos, bool[] passou)
        {
            for (int i = 0; i < media.Length; i++)
            {
                Console.WriteLine($"~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                Console.WriteLine($"~~~~~~~~~~~~~~~~~~~~~~~~~~~");

                media[i] = (notaMaior[i] + notaMenor[i]) / 2;

                Console.WriteLine($"A média do aluno {alunos[i]} é: ");
                //tostring em c# para formatar duas casas decimais
                Console.WriteLine($"{media[i].ToString("F")}");

                Console.WriteLine($"Sua maior nota foi {notaMaior[i]}");
                Console.WriteLine($"Sua menor nota foi {notaMenor[i]}");


                passou = Passou(passou, media);

                //Escrever se o usuario passou
                Console.WriteLine($"{passou[i]}");

                if (passou[i])
                {
                    Console.WriteLine($"O aluno atingiu nota suficiente para passar!");
                }
                else
                {
                    Console.WriteLine($"O aluno reprovou!");
                }

                Console.WriteLine($"~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                Console.WriteLine($"~~~~~~~~~~~~~~~~~~~~~~~~~~~");

            }

            return media;
        }

        static bool[] Passou(bool[] passou, decimal[] media)
        {
            decimal notaMinima = 70;

            for (int i = 0; i < media.Length; i++)
            {
                decimal mediaTeste = Convert.ToDecimal(media[i]);

                if (mediaTeste > notaMinima)
                {
                    passou[i] = true;
                }
                else
                {
                    passou[i] = false;
                }

            }
            return passou;
        }


        static decimal ChecarMaiorMedia(decimal[] media, decimal notaMediaMaior, string[] alunos)
        {
            int indice = 0;
            for (int i = 0; i < media.Length; i++)
            {
                if (media[i] > notaMediaMaior)
                {
                    notaMediaMaior = media[i];
                    indice = i;
                }
            }
            Console.WriteLine($"A maior media pertence ao aluno! {alunos[indice]}");
            Console.WriteLine($"{notaMediaMaior}");

            return notaMediaMaior;


        }

        static decimal ChecarMenorMedia(decimal[] media, decimal notaMediaMenor, string[] alunos)
        {
            int indice = 0;
            for (int i = 0; i < media.Length; i++)
            {
                if (i == 0)
                {
                    notaMediaMenor = media[i];
                    indice = i;
                }
                else if (media[i] < notaMediaMenor)
                {
                    notaMediaMenor = media[i];
                    indice = i;
                }
            }
            Console.WriteLine($"A menor media pertence ao aluno! {alunos[indice]}");
            Console.WriteLine($"{notaMediaMenor}");

            return notaMediaMenor;


        }


        static decimal ChecarMediaGeral(decimal[] media, decimal mediaGeral)
        {
            decimal somatorio = 0;
            int indice = 0;
            for (int i = 0; i < media.Length; i++)
            {
                somatorio = somatorio + media[i];
                indice = i;
            }
            mediaGeral = somatorio / indice;

            return mediaGeral;
        }








    }
}