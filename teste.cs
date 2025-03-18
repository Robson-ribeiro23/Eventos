using System;

namespace RobsonEx5
{
    class ExUm
    {
        public void Executar()
        {
            
            int[] idades = new int[5];
            string[] nomes = new string[5];
            int soma = 0;
            int media;

            Console.WriteLine("\n");

            for (int i = 0; i < 5; i++)
            {

                Console.WriteLine($"Insira o nome do aluno número {i + 1}.");
                nomes[i] = Console.ReadLine();
                Console.WriteLine($"Insira a idade do aluno número {i + 1}.");
                idades[i] = int.Parse(Console.ReadLine());
                Console.WriteLine("\n");

                soma += idades[i];
            }

            media = soma / 5;

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(nomes[i]);
                Console.WriteLine(idades[i]);
                Console.WriteLine("\n");
            }
            Console.WriteLine($"Média de idade dos alunos= {media}.\n");
        }
    }

    class ExDois
    {
        public void ImparPar()
        {

            Console.WriteLine("\n");
            Console.WriteLine("Digite um número: ");
            int numero = int.Parse(Console.ReadLine());
            int result = numero % 2;

            if (result != 0)
            {
                Console.WriteLine($"\n{numero} é ímpar!");
            }
            else
            {
                Console.WriteLine($"\n{numero} é par!");
            }
        }
    }

    class ExTres
    {
        public void Retangulo()
        {
            Console.WriteLine("\nInsira o valor da base do retângulo: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("\nInsira o valor da altura do retângulo: ");
            int a = int.Parse(Console.ReadLine());
            int ar = b * a;
            Console.WriteLine($"\nA área do retângulo é: {ar}");
        }
    }
        class ExQuatro
        {
            public void Dias()
            {
                Console.WriteLine("\nInsira sua idade: ");
                int id = int.Parse(Console.ReadLine());
                Console.WriteLine("\nInsira o número deste mês: ");
                int ms = int.Parse(Console.ReadLine());
                ms--;
                Console.WriteLine("\nInsira o dia: ");
                int da = int.Parse(Console.ReadLine());
                int dias = (ms * 30) + (id * 365) + da;
                Console.WriteLine($"\nSua idade expressa apenas em dias: (Aproximadamente {dias})");
            }
        }

    class ExCinco
    {
        public void MaisDezoito()
        {
            string[] nomes = new string[10];
            int[] idades = new int[10];
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"\nInsira o nome da pessoa número {i+1}: ");
                nomes[i] = Console.ReadLine();
                Console.WriteLine($"\nInsira a idade da pessoa número {i + 1}: ");
                idades[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("\n");
            for (int i = 0; i < 10; i++)
            {     
                if (idades[i] > 17)
                {
                    Console.WriteLine($"{nomes[i]} é de maior ({idades[i]})");
                }
                else
                {
                    Console.WriteLine($"{nomes[i]} é de menor ({idades[i]})");
                }
            }

        }
    }


    class Program
            {
                static void Main(string[] args)
                {
                    ExUm ex1 = new ExUm();
                    ExDois ex2 = new ExDois();
                    ExTres ex3 = new ExTres();
                    ExQuatro ex4 = new ExQuatro();
                    ExCinco ex5 = new ExCinco();
                   
                    while (true)
                    {
                       
                        Console.Clear();
                        Console.WriteLine("Lucas Lopes de Oliveira. 3 Semestre ADS\n");
                        Console.WriteLine("Selecione o exercício que deseja executar:");
                        Console.WriteLine("1 - Exercício 1");
                        Console.WriteLine("2 - Exercício 2");
                        Console.WriteLine("3 - Exercício 3");
                        Console.WriteLine("4 - Exercício 4");
                        Console.WriteLine("5 - Exercício 5");
                        Console.WriteLine("S - Sair");

                        var key = Console.ReadKey(true).Key;

                        if (key == ConsoleKey.D1)
                        {
                            ex1.Executar(); 
                        }
                        else if (key == ConsoleKey.D2)
                        {
                            ex2.ImparPar(); 
                        }
                        else if (key == ConsoleKey.D3)
                        {
                            ex3.Retangulo(); 
                        }
                        else if (key == ConsoleKey.D4)
                        {
                            ex4.Dias(); 
                        }
                        else if (key == ConsoleKey.D5)
                        {
                            ex5.MaisDezoito(); 
                        }
                        else if (key == ConsoleKey.S)
                        {
                            break; 
                        }
                        else
                        {
                            Console.WriteLine("\nOpção inválida, tente novamente.");
                            Console.ReadKey();  
                        }

                        Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
                        Console.ReadKey();  
                    }
                }
            }
        }
    
    // Robson Indalecio Barbosa Ribeiro ADS 3

    


