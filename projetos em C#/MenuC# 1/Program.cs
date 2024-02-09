

using System;
using static System.Console;
using System.Threading;

namespace menu_basico
{
    class Program
    {
        static void Main(string[] args)
        {
            int opc;
            string resp;

            do
            {
                Clear();
                WriteLine("************************");
                WriteLine("* Menu");
                WriteLine("Ordem alfabética [1]");
                WriteLine("Contador de vogal [2]");
                WriteLine("Codificador ZenitPolar [3]");
                WriteLine("Letreiro [4]");
                WriteLine("Desliza [5]");
                WriteLine("Nomes em Maiusclo [6]");
                WriteLine("Sair [7]");
                WriteLine("************************");

                opc = int.Parse(ReadLine());

                switch (opc)
                {
                    case 1:
                        NomesOrdenados();
                        break;
                    case 2:
                        ContaLetras();
                        break;
                    case 3:
                        ZenitPolar();
                        break;
                    case 4:
                        letreiro();
                        break;
                    case 5:
                        Desliza();
                        break;
                    case 6:
                        Maiusculo();
                        break;
                    case 7:
                        WriteLine("Saindo do programa...");
                        break;
                    default:
                        WriteLine("Opção inválida. Pressione Enter para continuar.");
                        ReadLine();
                        break;
                }

                if (opc != 7)
                {
                    WriteLine("Deseja voltar ao menu principal? (SIM ou NÃO)");
                    resp = ReadLine().ToUpper();
                }
                else
                {
                    resp = "NÃO";
                }
            } while (resp == "SIM" || resp == "S");
        }


        static void NomesOrdenados()
        {
            string lista, aux, resp;

            Console.Clear();
            do
            {
                Console.WriteLine("Escreva uma lista de nomes separados por ',' ");
                lista = Console.ReadLine();
                string[] nome = lista.Split(',');

                for (int i = 0; i < nome.Length - 1; i++)
                {
                    for (int p = nome.Length - 1; p > 0; p--)
                    {
                        if (nome[p].CompareTo(nome[p - 1]) < 0)
                        {
                            aux = nome[p];
                            nome[p] = nome[p - 1];
                            nome[p - 1] = aux;
                        }
                    }
                }

                for (int i = 0; i < nome.Length; i++)
                {
                    Console.WriteLine($"{i + 1} -> {nome[i]}");
                    Thread.Sleep(800);
                }

                Console.Write("Quer continuar? (SIM ou NÃO)");
                resp = Console.ReadLine().ToUpper();
            } while (resp == "SIM" || resp == "S");
        }

        static void ContaLetras()
        {
            string frase, vLetra, resp;
            int i, ContA = 0, ContE = 0, ContI = 0, ContO = 0, ContU = 0;

            Console.Clear();
            do
            {
                Console.WriteLine("Me diga a frase: ");
                frase = Console.ReadLine();

                frase = frase.Replace(" ", "");

                for (i = 0; i < frase.Length; i++)
                {
                    vLetra = frase.Substring(i, 1).ToLower();
                    switch (vLetra)
                    {
                        case "a":
                        case "ã":
                        case "á":
                        case "à":
                        case "â":
                            ContA++;
                            break;
                        case "e":
                        case "é":
                        case "ê":
                            ContE++;
                            break;
                        case "i":
                        case "í":
                            ContI++;
                            break;
                        case "o":
                        case "õ":
                        case "ô":
                            ContO++;
                            break;
                        case "u":
                        case "ú":
                            ContU++;
                            break;
                        default:
                            break;
                    }
                }

                Console.WriteLine($"A frase que foi digitada tem {frase.Length} caracteres.");
                Console.WriteLine($"E eu consegui encontrar um total de {ContA} vogais 'a' ou suas variações acentuadas.");
                Console.WriteLine($"E eu consegui encontrar um total de {ContE} vogais 'e' ou suas variações acentuadas.");
                Console.WriteLine($"E eu consegui encontrar um total de {ContI} vogais 'i' ou suas variações acentuadas.");
                Console.WriteLine($"E eu consegui encontrar um total de {ContO} vogais 'o' ou suas variações acentuadas.");
                Console.WriteLine($"E eu consegui encontrar um total de {ContU} vogais 'u' ou suas variações acentuadas.");
                Console.Write("Quer continuar? (SIM ou NÃO)");
                resp = Console.ReadLine().ToUpper();
            } while (resp == "SIM" || resp == "S");
        }

        static void ZenitPolar()
        {
            string resp;
            Console.Clear();
            do
            {
                Console.Write("Digite um texto: ");
                string input = Console.ReadLine();
                input = input.ToLower();
                string output = ConvertText(input);

                Console.WriteLine("Texto convertido: " + output);

                Console.WriteLine("Quer continuar? (SIM ou NÃO)");
                resp = Console.ReadLine().ToUpper();
            } while (resp == "SIM" || resp == "S");
        }

        static string ConvertText(string input)
        {
            string output = "";
            foreach (char c in input)
            {
                if (c == 'z')
                    output += 'p';
                else if (c == 'e')
                    output += 'o';
                else if (c == 'n')
                    output += 'l';
                else if (c == 'i')
                    output += 'a';
                else if (c == 't')
                    output += 'r';
                else if (c == 'p')
                    output += 'z';
                else if (c == 'o')
                    output += 'e';
                else if (c == 'l')
                    output += 'n';
                else if (c == 'a')
                    output += 'i';
                else if (c == 'r')
                    output += 't';
                else
                    output += c;
            }
            return output;
        }

        static void letreiro()
        {
            string resp;
            do
            {
                Console.Clear();
                Console.Write("Digite a frase: ");
                string frase = Console.ReadLine();
                int tamanho = frase.Length;


                frase = frase + " ";
                WriteLine("Clique espaço para parar");
                while (!KeyAvailable)
                {
                    Console.SetCursorPosition(8, 10);
                    Console.Write("[");
                    Console.SetCursorPosition(9, 10);
                    Console.Write(frase);
                    Console.SetCursorPosition(9 + tamanho + 1, 10);
                    Console.Write("]");
                    Thread.Sleep(200);

                    frase = frase.Substring(1) + frase[0];

                }
                WriteLine("\n\nQuer continuar?");
                resp = ReadLine();
                string respf = resp.Replace(" ", "");
                resp = respf.ToLower();
            } while (resp == "s" || resp == "sim");

        }

        static void Desliza()
        {
            string resp;
            do
            {
                string frase;
                int deslize;
                int x = 0;
                Console.Clear();
                WriteLine("Digite uma frase: ");
                frase = ReadLine();

                for (int i = 0; i < frase.Length; i++)

                {
                    char letra = frase[i];

                    for (deslize = 20; deslize >= x; deslize--)
                    {
                        SetCursorPosition(deslize, 10);
                        Write(letra);
                        Thread.Sleep(100);
                        SetCursorPosition(deslize, 10);
                        if (deslize > x)
                        {
                            Write(" ");
                        }
                    }
                    x++;
                }
                WriteLine("\nQuer continuar? ");
                resp = ReadLine();
                resp = resp.ToLower();

            } while (resp == "s" || resp == "sim");
        }

        static void Maiusculo()
        {
            string resp;
            do
            {
                Console.Clear();
                WriteLine("Escreva o nome:");
                string nome = ReadLine();
                string[] sepa = nome.Split(" ");
                int f = 0;
                for (int i = 0; i < sepa.Length; i++)

                {
                    string palavra = sepa[i];
                    if (palavra.StartsWith("de", StringComparison.OrdinalIgnoreCase) || palavra.StartsWith("da", StringComparison.OrdinalIgnoreCase) || palavra.StartsWith("do", StringComparison.OrdinalIgnoreCase) || palavra.StartsWith("dos", StringComparison.OrdinalIgnoreCase))
                    {
                        f++;
                    }
                    else if (!string.IsNullOrEmpty(palavra))
                    {
                        sepa[i] = char.ToUpper(palavra[0]) + palavra.Substring(1);
                    }
                }
                string nomeCorrigido = string.Join(" ", sepa);
                Write(nomeCorrigido);
                WriteLine("\nQuer continuar? ");
                resp = ReadLine();
            } while (resp == "s" || resp == "sim");
        }
    }
}
