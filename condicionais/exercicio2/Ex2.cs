using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace condicionais.exercicio2
{
    public class Ex2
    {
        public static void Main(string[] args)
        {
            List<int> numeros = new List<int> { 2, 7, 5, 10, 3, 8 };

            int resultadoPares = 0;
            int resultadoImpares = 0;
            int somaTotal = 0;
            for (int i = 0; i < numeros.Count; i++)
            {
                if (numeros[i] % 2 == 0)
                {
                    resultadoPares += numeros[i];
                }
                if (numeros[i] % 2 != 0)
                {
                    resultadoImpares += numeros[i];
                }

                somaTotal = resultadoPares + resultadoImpares;

            }
                Console.WriteLine($"A soma dos numeros pares: {resultadoPares}");
                Console.WriteLine($"A soma dos ímpares: {resultadoImpares}");
                Console.WriteLine($"A soma total é: {somaTotal}");

        }
    }
}
