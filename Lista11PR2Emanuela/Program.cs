using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista11PR2Emanuela
{
    internal class Program
    {

        public static void Exercicio1()
        {
            int num, pare = 0;
            int[] vet;
            vet = new int[1000];
            Random rand = new Random();

            for (int i = 0; pare < 1; i++)
            {
                vet[i] = rand.Next(1, 10);
                Console.WriteLine("digite um numero:");
                num = int.Parse(Console.ReadLine());

                for (int j = 0; j < 1000; j++)
                {
                    if (vet[j] == num)
                    {
                        Console.WriteLine("voce adivinhou o número!");
                        pare = 1;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("numero errado!");
                        break;
                    }
                }

            }
        }
        public static void Exercicio2()
        {
            int num, q = 0;
            int[] vet;
            vet = new int[20000];
            Random rand = new Random();

            for (int i = 0; i < 20000; i++)
            {
                vet[i] = rand.Next(1, 100);
            }

            Console.WriteLine("digite um numero:");
            num = int.Parse(Console.ReadLine());

            for (int i = 0; i < 20000; i++)
            {
                if (vet[i] == num)
                {
                    q = q + 1;
                }
            }
            Console.WriteLine("Esse número aparece no vetor: " + q);
        }
        public static void Exercicio3()
        {
            int[] vet, vetp, veti;
            vet = new int[10];
            vetp = new int[10];
            veti = new int[10];
            Random rand = new Random();

            for (int i = 0; i < 10; i++)
            {
                vet[i] = rand.Next(1, 100);
            }

            for (int i = 0; i < 10; i++)
            {
                if (vet[i] % 2 == 0)
                {
                    vetp[i] = vet[i] / 2;
                    Console.WriteLine("numero par ápós dividir por 2 no vetor é: " + vetp[i]);
                }
                else
                {
                    veti[i] = vet[i] * 3;
                    Console.WriteLine("numero impar ápós multiplicar por 3 no vetor é: " + veti[i]);
                }
            }
        }
        public static void Exercicio4()
        {
            int[] vet;
            vet = new int[5000];
            Random rand = new Random();

            for (int i = 0; i < 5000; i++)
            {
                vet[i] = rand.Next(1, 100);
            }


            for (int i = 1; i < 5000; i++)
            {
                for (int j = 2; j < vet[i]; j++)
                {
                    if (vet[i] % j == 1)
                    {
                        Console.WriteLine("o numero " + vet[i] + " é primo");
                    }
                }
            }
        }
       

        static void Main(string[] args)
        {
            int opcao;

            do
            {
                Console.WriteLine("====================================");
                Console.WriteLine("Para executar exercício 1 - digite 1");
                Console.WriteLine("Para executar exercício 2 - digite 2");
                Console.WriteLine("Para executar exercício 3 - digite 3");
                Console.WriteLine("Para executar exercício 4 - digite 4");
                Console.WriteLine("====================================");

                opcao = int.Parse(Console.ReadLine()); //lê a opção escolhida 

                switch (opcao)
                {
                    case 0:
                        Console.WriteLine("Obrigada, tchau!");
                        break;

                    case 1:
                        Exercicio1();
                        break;

                    case 2:
                        Exercicio2();
                        break;

                    case 3:
                        Exercicio3();
                        break;

                    case 4:
                        Exercicio4();
                        break;

                    default:
                        Console.WriteLine("Opção Inválida");
                        break;
                }

            } while (opcao != 0);

        }
    }
}
