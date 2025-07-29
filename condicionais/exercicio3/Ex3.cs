using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace condicionais.exercicio3
{
    public class Ex3
    {
        public static void Main(string[] args)
        {
            Dictionary<string, double> produtos = new Dictionary<string, double>();

            Boolean continuar = true;
            while (continuar)
            {

            Console.Write("Digite o nome do produto (ou sair para encerrar): ");
            string produto = Console.ReadLine();
            if (produto.ToLower() == "sair")
            {
                continuar = false;
                break;
                }


                Console.Write("Digite o preço: ");
                if(double.TryParse(Console.ReadLine(), out double preco))
                {
                    if (preco < 0)
                    {
                        Console.WriteLine("O preço não pode ser negativo. Tente novamente.");
                        continue;
                    }
                    produtos[produto] = preco;
                }
                else
                {
                    Console.WriteLine("Preço inválido. Tente novamente.");
                }
            }

            Console.WriteLine("\nProdutos cadastrados:");
            double total = 0;

            foreach(var item in produtos)
            {
                Console.WriteLine($"Produto: {item.Key}, Preço: R${item.Value:F2}");
                total += item.Value;
            }

            Console.WriteLine($"\nTotal dos produtos: R${total:F2}");

        }
    }
}
