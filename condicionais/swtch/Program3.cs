//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace condicionais.swtch
//{
//    public class Program3
//{
//    public static void Main(string[] args)
//    {
//            Console.WriteLine("Escolha uma operação: ");
//            Console.WriteLine("1 - Soma");
//            Console.WriteLine("2 - Subtração");
//            Console.WriteLine("3 - Multiplicação");
//            Console.WriteLine("4 - Divisão");

//            int operacao = int.Parse(Console.ReadLine());

//            Console.WriteLine("Digite o primeiro número: ");
//            double numero1 = double.Parse(Console.ReadLine());

//            Console.WriteLine("Digite o segundo número: "); 
//            double numero2 = double.Parse(Console.ReadLine());
//            double resultado = 0;
//            switch (operacao)
//            {
//                case 1: 
//                    resultado = numero1 + numero2;
//                    Console.WriteLine("O resultado da soma é: " + resultado);
//                    break;

//                case 2: 
//                    resultado = numero1 - numero2;
//                    Console.WriteLine("O resultado da subtração é: " + resultado);
//                    break;

//                case 3:
//                    resultado = numero1 * numero2;
//                    Console.WriteLine("O resultado da multiplicação é: " + resultado);
//                    break;

//                case 4: 
//                    if (numero2 != 0)
//                    {
//                        resultado = numero1 / numero2;
//                        Console.WriteLine("O resultado da divisão é: " + resultado);
//                    }
//                    else
//                    {
//                        Console.WriteLine("Erro: Divisão por zero não é permitida.");
//                    }
//                    break;
//                default:
//                    Console.WriteLine("Operação inválida. Por favor, escolha uma operação válida.");
//                    break;
//            }
//        }
//}
//}