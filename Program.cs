using System;

namespace projetoPratico
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcaoUsuario;

            do
            {
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("\n--- LHM Calculadora ---");
                Console.ResetColor();

                Console.WriteLine("\nOlá usuário, vamos começar nossos procedimento. ");
                Console.WriteLine("Primeiro, vou te mostrar suas opções de conta: \n ");

                Console.WriteLine("SO - Soma");
                Console.WriteLine("SU - Subtração");
                Console.WriteLine("MU - Multiplicação");
                Console.WriteLine("DI - Divisão");
                Console.WriteLine("RA - Radiciação");
                Console.WriteLine("EX - Exponenciação\n");

                Console.WriteLine("X - Sair do programa\n");

                Console.WriteLine("Agora, escolha sua opcao, por favor: ");
                opcaoUsuario = Console.ReadLine().ToUpper();

                if (opcaoUsuario == "SO")
                {
                    ExibeContaSoma();
                }
                else if (opcaoUsuario == "MU")
                {
                    ExibeContaMulti();
                }
                else if (opcaoUsuario == "SU")
                {
                    ExibeContaSubtracao();
                }
                else if (opcaoUsuario == "DI")
                {
                    ExibeContaDivisao();
                }
                else if (opcaoUsuario == "EX")
                {
                    ExibeContaEX();
                }
                else if (opcaoUsuario == "RA")
                {
                    ExibeContaRadiciacao();
                }
            }
            while (opcaoUsuario != "X");
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("\nObrigado por usar a LHM Calculadora.\n");
                Console.ResetColor();
            }
        }
        static void ExibeContaSoma()
        {
            Console.WriteLine("\nLegal, quais números você quer somar? ");

            Console.Write("Primeiro número: ");
            int somaUm = Convert.ToInt32(Console.ReadLine());

            Console.Write("E o segundo: ");
            int somaDois = Convert.ToInt32(Console.ReadLine());

            int somaResposta = somaUm + somaDois;

            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine($"\nO resultado da soma dos números {somaUm} e {somaDois} é {somaResposta}\n");
            Console.ResetColor();

            Console.WriteLine("Clique em qualquer tecla para continuar... ");
            Console.ReadKey();
        }
        static void ExibeContaMulti()
        {
            Console.WriteLine("\nLegal, quais números você quer multiplicar? ");

            Console.Write("Primeiro número: ");
            int multiUm = Convert.ToInt32(Console.ReadLine());

            Console.Write("E o segundo: ");
            int multiDois = Convert.ToInt32(Console.ReadLine());

            int multiResposta = multiUm * multiDois;

            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine($"\nA multiplicação dos números {multiUm} e {multiDois} é {multiResposta}\n");
            Console.ResetColor();

            Console.WriteLine("Clique em qualquer tecla para continuar... ");
            Console.ReadKey();
        }
        static void ExibeContaSubtracao()
        {
            Console.WriteLine("\nLegal, quais números você quer subtrair? ");

            Console.Write("Primeiro número: ");
            int subUm = Convert.ToInt32(Console.ReadLine());

            Console.Write("E o segundo: ");
            int subDois = Convert.ToInt32(Console.ReadLine());

            int subResposta = subUm - subDois;

            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine($"\nA subtração dos números {subUm} e {subDois} é {subResposta}\n");
            Console.ResetColor();

            Console.WriteLine("Clique em qualquer tecla para continuar... ");
            Console.ReadKey();
        }
        static void ExibeContaDivisao()
        {
            Console.WriteLine("\nLegal, quais números você quer dividir? ");

            Console.Write("Primeiro número: ");
            int divUm = Convert.ToInt32(Console.ReadLine());

            Console.Write("E o segundo: ");
            int divDois = Convert.ToInt32(Console.ReadLine());

            int divResposta = divUm / divDois;

            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine($"\nA divisão dos números {divUm} e {divDois} é {divResposta}\n");
            Console.ResetColor();

            Console.WriteLine("Clique em qualquer tecla para continuar... ");
            Console.ReadKey();
        }
        static void ExibeContaEX()
        {
            Console.WriteLine("\nEntão, coloque os valores pedidos ");

            Console.Write("Valor da base: ");
            double exBase = Convert.ToDouble(Console.ReadLine());

            Console.Write("Valor do expoente: ");
            double exExpoente = Convert.ToDouble(Console.ReadLine());

            double exResposta = Math.Pow(exBase, exExpoente);

            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine($"\nO resultado da conta é {exResposta}\n");
            Console.ResetColor();

            Console.WriteLine("Clique em qualquer tecla para continuar... ");
            Console.ReadKey();
        }
        static void ExibeContaRadiciacao()
        {
            Console.WriteLine("\nEntão, para calcularmos a radiciação, coloque o valor: ");
            double radiValor = Convert.ToDouble(Console.ReadLine());

            double radiResposta = Math.Sqrt(radiValor);

            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine($"\nO resultado da conta é {radiResposta}\n");
            Console.ResetColor();

            Console.WriteLine("Clique em qualquer tecla para continuar... ");
            Console.ReadKey();
        }
    }
}