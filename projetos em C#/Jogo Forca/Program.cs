using System;
using static System.Console;
using System.Threading;
using static System.Random;
namespace forca
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] brinquedo = { "bola", "quebra-cabeça", "boneca", "yo-yo", "carrinho", "pião", "lego", "xadrez", "trompete", "dominó", "patinete" };
            string[] fruta = { "maçã", "banana", "uva", "kiwi", "pessêgo", "manga", "laranja", "melancia", "goiaba", "framboesa", "cereja" };
            string[] filme = { "Titanic", "Avatar", "Star Wars", "Inception", "O Poderoso Chefão", "Harry Potter", "Matrix", "Toy Story", "Jurassic Park", "Os Incríveis", "A Origem" };
            string[] nome = { "Lucas", "Mariana", "Pedro", "Gabriela", "Rafael", "Isabela", "Mateus", "Beatriz", "Carla", "João", "Daniel" };
            string[] país = { "Brasil", "França", "Argentina", "Japão", "Espanha", "Itália", "Austrália", "Índia", "Egito", "Alemanha", };
            string[] animal = { "gato", "cão", "tartaruga", "girafa", "coelho", "leão", "urso", "pinguim", "iguana", "elefante" };
            Random s = new Random();
            int n1 = s.Next(1, 6);
            Random d = new Random();
            int n2 = d.Next(0, 10);
            string palavra = "";
            string dica = "";
            switch (n1)
            {
                case 1:
                    palavra = brinquedo[n2].ToLower();
                    dica = "brinquedos";
                    break;
                case 2:
                    palavra = fruta[n2].ToLower();
                    dica = "frutas";
                    break;
                case 3:
                    palavra = filme[n2].ToLower();
                    dica = "filmes";
                    break;
                case 4:
                    palavra = nome[n2].ToLower();
                    dica = "nomes de pessoas";
                    break;
                case 5:
                    palavra = país[n2].ToLower();
                    dica = "países";
                    break;
                case 6:
                    palavra = animal[n2].ToLower();
                    dica = "animais";
                    break;

            }
            string virgem = palavra;
            string comAcentos = "ÄÅÁÂÀÃäáâàãÉÊËÈéêëèÍÎÏÌíîïìÖÓÔÒÕöóôòõÜÚÛüúûù";
            string semAcentos = "AAAAAAaaaaaEEEEeeeeIIIIiiiiOOOOOoooooUUUuuuu";
            for (int i = 0; i < comAcentos.Length; i++)
            {
                palavra = palavra.Replace(comAcentos[i].ToString(), semAcentos[i].ToString());
            }

            Write(palavra);

            string letra = "", digitadas = "", da = "";
            SetCursorPosition(10, 2);
            Write("dica: " + dica);
            string resp;
            int cont;
            bool real = false;
            bool erro = false;
            int tamanho = palavra.Length;
            int tentativas = 0;
            char[] delimiters = { '-', ' ' }; // Especifica os delimitadores

            string[] partes = palavra.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);

            string palavraSemDelimitadores = string.Join("", partes);
            palavra = palavraSemDelimitadores;
            int codigo = 92;
            char letraa = Convert.ToChar(codigo);
            do
            {
                SetCursorPosition(1, 1);
                Write('|');
                SetCursorPosition(2, 1);
                Write('-');
                SetCursorPosition(3, 1);
                Write('-');
                SetCursorPosition(4, 1);
                Write('|');
                SetCursorPosition(1, 2);
                Write('|');
                SetCursorPosition(1, 3);
                Write('|');
                SetCursorPosition(1, 4);
                Write('|');
                SetCursorPosition(10, 3);
                Write("Quer chutar ou escrever uma letra? [c para chutar l para letra]");
                resp = ReadLine().ToLower();
                SetCursorPosition(10, 3);
                Write("                                                                  ");

                if (resp == "c")
                {
                    SetCursorPosition(10, 4);
                    Write("Escreva seu chute: ");
                    resp = ReadLine();
                    SetCursorPosition(10, 4);
                    Write("                                        ");
                    if (resp == virgem)
                    {
                        SetCursorPosition(30, 10);
                        Write("Parabéns acertou!!");
                        break;
                    }
                    else
                    {
                        real = true;
                        erro = true;
                    }
                }

                if (resp == "l")
                {
                    string cerrado = "";
                    real = true;
                    SetCursorPosition(10, 4);
                    Write("Digite uma letra: ");
                    letra = ReadLine().ToLower();
                    char il = ' ';
                    int c = 0;
                    for (int under = 0; under < palavra.Length; under++)
                    {



                        char caractere = virgem[under];

                        if (letra[0] == caractere)
                        {
                            SetCursorPosition(under + 30, 10);
                            Write(letra);
                            cerrado += letra;
                        }
                        else
                        {
                            if (caractere == ' ')
                            {
                                SetCursorPosition(under + 30, 10);
                                Write(" ");
                            }
                            else if (caractere == '-')
                            {
                                SetCursorPosition(under + 30, 10);
                                Write("-");

                            }
                            else
                            {
                                SetCursorPosition(under + 30, 10);
                                Write("_");

                            }
                        }



                    }

                    if (palavra.Contains(letra))
                    {

                        SetCursorPosition(10, 6);
                        if (da.Contains(letra))
                        {

                            SetCursorPosition(10, 6);
                            Write("Letra presente na palavra, porem já digitada");
                            SetCursorPosition(10, 6);
                            Thread.Sleep(1000);
                            Write("                                                ");
                        }

                        SetCursorPosition(10, 6);
                        WriteLine("acertou a letra");
                        SetCursorPosition(10, 6);
                        Thread.Sleep(1000);
                        Write("                    ");
                        da += letra;
                    }
                    else
                    {
                        if (digitadas.Contains(letra))
                        {
                            SetCursorPosition(10, 6);
                            WriteLine("Você já digitou a letra ");
                            SetCursorPosition(10, 6);
                            Thread.Sleep(1000);
                            WriteLine("                          ");
                        }
                        else
                        {
                            tentativas += 1;

                        }


                    }
                }
                if (real == true)
                {

                }
                else
                {
                    SetCursorPosition(12, 8);
                    Write("Letra n permitida ");
                    Thread.Sleep(1000);
                    SetCursorPosition(12, 8);
                    Write("                  ");
                    letra = "";
                }
                if (tentativas == 1)
                {
                    SetCursorPosition(4, 2);
                    Write('O');
                }
                if (tentativas == 2)
                {
                    SetCursorPosition(4, 3);
                    Write('|');
                }
                if (tentativas == 3)
                {
                    SetCursorPosition(3, 3);
                    Write('/');
                }
                if (tentativas == 4)
                {
                    SetCursorPosition(5, 3);
                    Write(letraa);
                }
                if (tentativas == 5)
                {
                    SetCursorPosition(5, 4);
                    Write(letraa);
                }
                if (tentativas == 6)
                {
                    SetCursorPosition(3, 4);
                    Write("/");
                }
                if (erro == true || tentativas == 6)
                {
                    SetCursorPosition(30, 10);
                    Write("PARABÉNS VOCÊ ERROU HAHAHA!!");
                    break;
                }
                digitadas += letra;
                SetCursorPosition(10, 5);
                Write("letras já digitadas: " + digitadas);
            } while (true);
        }

    }
}