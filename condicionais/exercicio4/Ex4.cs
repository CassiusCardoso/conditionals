using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace condicionais.exercicio4
{
    public class Ex4
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(" ----------- NOTAS ALUNOS ----------- ");

            Dictionary<string, List<float>> notasAlunos  = new Dictionary<string, List<float>>();
            notasAlunos.Add("João", new List<float> { 7.5f, 8.0f, 6.5f });
            notasAlunos.Add("Maria", new List<float> { 9.0f, 8.5f, 7.0f });
            notasAlunos.Add("Pedro", new List<float> { 6.0f, 5.5f, 7.0f });

            Console.WriteLine("Digite o nome do aluno para ver as notas: ");
            string nomeAluno = Console.ReadLine();
            if (notasAlunos.ContainsKey(nomeAluno))
            {
                float media = notasAlunos[nomeAluno].Average();
                Console.WriteLine($"A nota do aluno {nomeAluno} é {media}");
            }

            // Aluno com maior média
            foreach (var aluno in notasAlunos) { 
                Console.WriteLine($"Aluno: {aluno.Key}, Notas: {string.Join(", ", aluno.Value)}");
            }

        }

    }
}
