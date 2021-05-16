using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class calculadora
    {
        static void Main(string[] args)
        {
            double num1;
            double num2;
            int op = 0;
            double result = 0.0;

        inicio:
            //Console.Clear();


            Console.WriteLine("---- Opções ---- ");
            Console.WriteLine("1. Soma ");
            Console.WriteLine("2. Subtração ");
            Console.WriteLine("3. Multiplicação ");
            Console.WriteLine("4. Divisão ");
            Console.WriteLine("---------------- ");
            Console.WriteLine("---------------- ");

            if (op == 5)
            {

            }
            else
            {
                try
                {

                    while (op != 5)
                    {
                        Console.WriteLine("Digite uma opção: ");
                        op = int.Parse(Console.ReadLine());
                        Console.WriteLine("Escreva o primeiro valor: ");
                        num1 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Escreva o segundo valor: ");
                        num2 = double.Parse(Console.ReadLine());

                        switch (op)
                        {

                            case 1:
                                result = num1 + num2;
                                break;
                            case 2:
                                result = num1 - num2; 
                                break;
                            case 3:
                                result = num1 * num2;
                                break;
                            case 4:
                                result = num1 / num2;
                                break;
                            default:
                                Console.WriteLine("invalid input");
                                break;

                        }
                        Console.WriteLine("O resultado é: " + result);
                        Console.WriteLine("Clique em Enter");
                        Console.ReadKey();
                        goto inicio;

                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                }
        }
        }
    }

