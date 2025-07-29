using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace condicionais.dia
{
    public class Program4
    {
        public static void Main(string[] args) { 
            
            Console.WriteLine("Digite qual dia da semana você quer saber: ");
            string dia = Console.ReadLine().ToLower();

            switch (dia) { 
                case "segunda":
                    Console.WriteLine(" É dia de trabalho.");
                    break;
                case "terça":
                    Console.WriteLine(" É dia de trabalho.");
                    break;
                case "quarta":
                    Console.WriteLine(" É dia de trabalho.");
                    break;
                case "quinta":
                    Console.WriteLine(" É dia de trabalho.");
                    break;
                case "sexta":
                    Console.WriteLine(" É dia de trabalho.");
                    break;
                case "sábado":
                    Console.WriteLine(" É dia de descanso.");
                    break;
                case "domingo":
                    Console.WriteLine(" É dia de descanso.");
                    break;
            }

        }
    }
}
