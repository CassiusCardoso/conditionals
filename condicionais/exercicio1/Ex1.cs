using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace condicionais.exercicio1
{
    public class Ex1
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite uma frase: ");
            string frase = Console.ReadLine().ToLower();
            string[] palavras = frase.Split(' ');
            Dictionary<string, int> contagemPalavras = new Dictionary<string, int>();

            foreach (string palavra in palavras) {
                if (contagemPalavras.ContainsKey(palavra)) {
                    contagemPalavras[palavra]++;
                } else {
                    contagemPalavras[palavra] = 1;
                }
            }
            foreach(var item in contagemPalavras) {
                Console.WriteLine($"A palavra '{item.Key}' aparece {item.Value} vezes.");
            }

        }
    }
}
