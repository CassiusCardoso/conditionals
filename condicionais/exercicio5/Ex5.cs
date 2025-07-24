//using System;
//using System.Collections.Generic;
//using System.Linq;

//namespace condicionais.exercicio5
//{
//    public class Ex5
//    {
//        public static void Main(string[] args)
//        {
//            List<int> numeros = Enumerable.Range(1, 100).ToList();
//            List<int> numerosPrimosList = new List<int>();

//            foreach (int numero in numeros)
//            {
//                if (EhPrimo(numero))
//                {
//                    numerosPrimosList.Add(numero);
//                }
//            }

//            Console.WriteLine($"A quantidade de números primos é: {numerosPrimosList.Count}");
//            Console.WriteLine("Os números primos são:");
//            Console.WriteLine(string.Join(", ", numerosPrimosList));
//        }

//        // Função auxiliar para verificar se o número é primo
//        static bool EhPrimo(int numero)
//        {
//            if (numero < 2) return false;

//            for (int i = 2; i <= Math.Sqrt(numero); i++)
//            {
//                if (numero % i == 0)
//                {
//                    return false;
//                }
//            }

//            return true;
//        }
//    }
//}
