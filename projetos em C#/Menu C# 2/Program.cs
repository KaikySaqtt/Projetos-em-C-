using System;
using static System.Console;

namespace menubase
{
    class Program
    {
        static void Main(string[] args)
        {

            int opc;
            Console.WriteLine("************************");
            Console.WriteLine("*Menu");
            Console.WriteLine("*Notas[1]");
            Console.WriteLine("*Calculos[2]");
            Console.WriteLine("*Tabuada[3]");
            Console.WriteLine("*Adivinha[4]");
            Console.WriteLine("*Comparação[5]");

            Console.WriteLine("************************");

            opc = int.Parse(Console.ReadLine());

            switch (opc)
            {
                case 1:
                    Notas();
                    break;
                case 2:
                    Calculo();
                    break;
                case 3:
                    tabuada();
                    break;
                case 4:
                    adivinha();
                    break;
                case 5:
                    comparação();
                    break;

            }


        }


        static void Notas()
        {
            string Vresp;
            float n1, n2, n3, n4, n5, n6;

            do
            {
                Console.Clear();
                Console.WriteLine("Qual é a primeira média?");
                n1 = float.Parse(Console.ReadLine());
                Console.WriteLine("Qual é a segunda média?");
                n2 = float.Parse(Console.ReadLine());
                Console.WriteLine("Qual é a terceira média?");
                n3 = float.Parse(Console.ReadLine());
                Console.WriteLine("Qual é a quarta média?");
                n4 = float.Parse(Console.ReadLine());

                n5 = n1 + n2 + n3 + n4;
                n6 = n5 / 4;

                Console.WriteLine("Sua média é: " + n6);

                if (n6 <= 5)
                {
                    Console.WriteLine("\nParabéns, você reprovou e sua nota é I.");
                }
                else if (n6 > 5 && n6 <= 7.5)
                {
                    Console.WriteLine("\nParabéns, você passou e sua nota é R.");
                }
                else if (n6 > 7.5 && n6 < 9.5)
                {
                    Console.WriteLine("\nParabéns, você passou e sua nota é B.");
                }
                else if (n6 > 9.5)
                {
                    Console.WriteLine("\nParabéns, você passou com a nota máxima: MB.");
                }

                Console.WriteLine("Deseja continuar?");
                Vresp = Console.ReadLine();
            } while (Vresp.ToLower() == "sim" || Vresp.ToLower() == "s");

            Console.WriteLine("Até mais!");
        }
        static void Calculo()
        {
            string resposta, Vresp;
            int n1, n2, n3;

            do
            {
                Console.WriteLine("Vamos calcular números?");
                resposta = Console.ReadLine();

                n1 = 0;
                n2 = 0;

                if (resposta == "sim")
                {
                    Console.WriteLine("Primeiro número é? ");
                    n1 = int.Parse(Console.ReadLine());

                    Console.WriteLine("E segundo número é? ");
                    n3 = int.Parse(Console.ReadLine());
                    n2 = -n3;

                    Console.WriteLine("Subtração: " + (n1 + n2));
                    Console.WriteLine("Adição: " + (n1 - n2));
                    Console.WriteLine("Divisão: " + (n1 / n3));
                    Console.WriteLine("Multiplicação: " + (n1 * n3));
                }
                else
                {
                    Console.WriteLine("Ok");
                }

                Console.WriteLine("Quer continuar? (s/n)");
                Vresp = Console.ReadLine();
            } while (Vresp == "s" || Vresp == "sim");
        }
        static void tabuada()
        {

            string resp;
            int i, n;
            do
            {

                WriteLine("escreva um numero");
                n = int.Parse(ReadLine());
                for (i = 1; i <= 10; i++)
                {
                    WriteLine(n + "x" + i + "=" + (n * i));
                }
                WriteLine("quer continuar?");
                resp = (ReadLine());
            } while (resp == "sim");
        }
        static void adivinha()
        {
            int num, p, i;
            string resp;

            Random s = new Random();

            do
            {
                Clear();
                num = s.Next(1, 10);

                do
                {
                    WriteLine("Escolha um número:");
                    p = int.Parse(ReadLine());
                    if (p != num)
                    {
                        WriteLine("Tente novamente.");
                    }
                } while (p != num);

                WriteLine("Parabéns, você acertou!");
                WriteLine("Deseja continuar? (sim/não)");
                resp = ReadLine();

            } while (resp == "sim" || resp == "s");
        }
        static void comparação()
        {
            int n1, n2;
            string resp;
            do
            {
                Console.WriteLine("informe o 1° numero");
                n1 = int.Parse(Console.ReadLine());
                Console.WriteLine("informe o 2° numero");
                n2 = int.Parse(Console.ReadLine());
                if (n1 > n2)
                {
                    Console.WriteLine(n1 + " é maior que " + n2);
                }
                else
                {
                    Console.WriteLine(n2 + " é maior que " + n1);
                }
                Console.WriteLine("Deseja continuar?: ");
                resp = ReadLine();
            } while (resp == "sim" || resp == "s");


        }

    }
}
