using System;

namespace menu_basico
{
    class Program
    {
        static void Main(string[] args)
        {

            int opc;
            Console.WriteLine("************************");
            Console.WriteLine("*Menu");
            Console.WriteLine("*Mes e dia[1]");
            Console.WriteLine("*Siglas dos estados[2]");
            Console.WriteLine("*Extenso de um numero de 0-1000[3]");
            Console.WriteLine("************************");

            opc = int.Parse(Console.ReadLine());

            switch (opc)
            {
                case 1:
                    Mesdia();
                    break;
                case 2:
                    estados();
                    break;

                case 3:
                    extenso();
                    break;

            }



        }
        static void Mesdia()
        {
            string[] mes = { " ", "janeiro", "fevereiro", "março", "abril", "maio", "junho", "julho", "agosto", "setembro", "outubro", "novembro", "dezembro" };
            string[] dia = { " ", "domingo", "segunda-feira", "terça-feira", "quarta-feira", "quinta-feira", "sexta-feira", "sabado" };
            int D, M;
            string resp, opcao;

            Console.WriteLine("quer ver mes ou dia?");
            opcao = Console.ReadLine();
            if (opcao == "mes")
            {
                do
                {
                    Console.WriteLine("Qual seu mes?");
                    M = int.Parse(Console.ReadLine());

                    if (M < 1 || M > 12)
                    {
                        Console.WriteLine("Seu mes não bate com o calendario cristão");
                    }
                    else
                    {
                        Console.WriteLine(M + "Corresponde a " + mes[M]);
                    }
                    Console.WriteLine("Quer continuar?");
                    resp = Console.ReadLine();
                } while (resp == "sim" || resp == "sim");
            }
            if (opcao == "dia")
            {
                do
                {
                    Console.WriteLine("Qual seu dia?");
                    D = int.Parse(Console.ReadLine());
                    if (D < 1 || D > 7)
                    {
                        Console.WriteLine("Seu dia não bate com o calendario cristão");
                    }
                    else
                    {
                        Console.WriteLine(D + "Corresponde a " + dia[D]);
                    }
                    Console.WriteLine("Quer continuar?");
                    resp = Console.ReadLine();
                } while (resp == "sim" || resp == "sim");
            }


        }
        static void extenso()
        {
            string[] unidade = { "zero", "um", "dois", "tres", "quatro", "cinco", "seis", "sete", "oito", "nove", "dez", "onze", "doze", "treze", "quatorze", "quinze", "dezesseis", "dezessete", "dezoito", "dezenove" };
            string[] dezena = { "", "", "vinte", "trinta", "quarenta", "cinquenta", "sessenta", "setenta", "oitenta", "noventa" };
            string[] centena = { "", "cento", "duzentos", "trezentos", "quatrocentos", "quinhentos", "seiscentos", "setecentos", "oitocentos", "novecentos" };
            string resp;
            int n, c, d, u, nd, nc;

            do
            {
                Console.Clear();
                Console.WriteLine("Digite algum numero de 0-1000");
                n = int.Parse(Console.ReadLine());
                if (n < 0 || n > 1000)
                {
                    Console.WriteLine("Numero invalido");
                }
                else if (n < 20)
                {
                    Console.WriteLine(unidade[n]);
                }
                else if (n < 100)
                {
                    d = n / 10;
                    u = n % 10;

                    Console.WriteLine(dezena[d]);
                    if (u > 0)
                    {
                        Console.WriteLine(" e " + unidade[u]);
                    }

                }
                else if (n == 100)
                {
                    Console.WriteLine("Cem");
                }
                if (n == 1000)

                {
                    Console.WriteLine("Mil");
                }
                else if (n < 1000 && n != 100)
                {
                    c = n / 100;
                    d = n / 10;
                    u = n % 10;
                    nc = d % 10;
                    nd = n - c * 100;

                    Console.Write(centena[c]);
                    if (nc < 11 && nc > 1)
                    {
                        Console.Write(" e " + dezena[nc]);
                    }
                    if (nd < 20 && nd > 9 & nd != n)
                    {
                        Console.Write(" e " + unidade[nd]);
                    }
                    if (u > 0 && u < 10 && nd < 10)
                    {
                        Console.Write(" e " + unidade[u]);
                    }
                    if (nd > 19)
                    {
                        Console.Write(" e " + unidade[u]);
                    }

                }
                Console.WriteLine("\nQuer continuar?: ");
                resp = (Console.ReadLine());
            } while (resp == "sim" || resp == "s");




        }
        static void estados()
        {
            string[,] estado = new string[27, 2];
            estado[0, 0] = "AC"; estado[0, 1] = "Acre";
            estado[1, 0] = "AL"; estado[1, 1] = "Alagoas";
            estado[2, 0] = "AP"; estado[2, 1] = "Amapa";
            estado[3, 0] = "AM"; estado[3, 1] = "Amazonas";
            estado[4, 0] = "BA"; estado[4, 1] = "Bahia";
            estado[5, 0] = "CE"; estado[5, 1] = "Ceará";
            estado[6, 0] = "ES"; estado[6, 1] = "Espirito Santo";
            estado[7, 0] = "GO"; estado[7, 1] = "Goiás";
            estado[8, 0] = "MA"; estado[8, 1] = "Maranhão";
            estado[9, 0] = "MT"; estado[9, 1] = "Mato Grosso";
            estado[10, 0] = "MS"; estado[10, 1] = "Mato Grosso do Sul";
            estado[11, 0] = "MG"; estado[11, 1] = "Minas Gerais";
            estado[12, 0] = "PA"; estado[12, 1] = "Pará";
            estado[13, 0] = "PB"; estado[13, 1] = "Paraíba";
            estado[14, 0] = "PR"; estado[14, 1] = "Paraná";
            estado[15, 0] = "PE"; estado[15, 1] = "Pernambuco";
            estado[16, 0] = "PI"; estado[16, 1] = "Piauí";
            estado[17, 0] = "RJ"; estado[17, 1] = "Rio de Janeiro";
            estado[18, 0] = "RN"; estado[18, 1] = "Rio Grande do Norte";
            estado[19, 0] = "RS"; estado[19, 1] = "Rio Grande do Sul";
            estado[20, 0] = "RO"; estado[20, 1] = "Rondonia";
            estado[21, 0] = "RR"; estado[21, 1] = "Roraima";
            estado[22, 0] = "SC"; estado[22, 1] = "Santa Catarina";
            estado[23, 0] = "SP"; estado[23, 1] = "São Paulo";
            estado[24, 0] = "SE"; estado[24, 1] = "Sergipe";
            estado[25, 0] = "TO"; estado[25, 1] = "Tocantins";
            estado[26, 0] = "DF"; estado[26, 1] = "Distrito Federal";

            string resp;
            int i;
            bool achou;

            Console.Write("Informe uma sigla ou nome de estado: ");
            resp = Console.ReadLine();

            achou = false;
            for (i = 0; i <= 26; i++)
            {
                if (resp == estado[i, 0])
                {
                    Console.WriteLine("\n" + resp + " corresponde a " + estado[i, 1]);
                    achou = true;
                }

                if (resp == estado[i, 1])
                {
                    Console.WriteLine("\n" + resp + " corresponde a " + estado[i, 0]);
                    achou = true;
                }
            }

            if (!achou)
            {
                Console.WriteLine("\nA sigla do estado não existe");
            }

        }
    }

}
