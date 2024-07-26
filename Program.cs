using System;
using System.Collections.Generic;

namespace notas
{
    class Program
    {
        // Dicionário para armazenar alunos e suas notas
        static Dictionary<string, List<double>> aluno = new Dictionary<string, List<double>>();

        static void Main()
        {
            // Dados iniciais de alunos e notas
            aluno.Add("Luisa", new List<double> { 9.0, 6.3, 10.0 });
            aluno.Add("Julio", new List<double> { 5.5, 7.4, 6.2 });
            aluno.Add("Maira", new List<double> { 7.0, 8.3, 9.9 });

            Console.WriteLine("Bem-vindo ao Sistema de Notas");

            while (true)
            {
                Console.WriteLine("\nOpções:");
                Console.WriteLine("1 - Cadastro de alunos e notas");
                Console.WriteLine("2 - Mostrar todos os alunos e suas médias");
                Console.WriteLine("3 - Sair do Programa");

                Console.Write("Digite uma opção: ");
                string escolha = Console.ReadLine();

                switch (escolha)
                {
                    case "1":
                        CadastrarAlunosENotas();
                        break;

                    case "2":
                        MostrarAlunos();
                        break;

                    case "3":
                        Console.WriteLine("\nSaindo do Programa...");
                        return;

                    default:
                        Console.WriteLine("\nOpção inválida. Tente novamente.");
                        break;
                }
            }
        }

        static void CadastrarAlunosENotas()
        {
            Console.WriteLine("\nDigite o nome do aluno para cadastrar:");
            string nome = Console.ReadLine();

            Console.WriteLine("\nDigite 3 notas para o aluno");

            // Lista para armazenar as notas do aluno
            List<double> notas = new List<double>();

            Console.Write("Nota 1: ");
            double nota1 = double.Parse(Console.ReadLine());
            notas.Add(nota1);

            Console.Write("Nota 2: ");
            double nota2 = double.Parse(Console.ReadLine());
            notas.Add(nota2);

            Console.Write("Nota 3: ");
            double nota3 = double.Parse(Console.ReadLine());
            notas.Add(nota3);

            // Adicionando ou atualizando as notas do aluno no dicionário
            aluno[nome] = notas;

            Console.WriteLine($"\nNotas do aluno {nome} cadastradas com sucesso.");
        }

        static void MostrarAlunos()
        {
            Console.WriteLine("\nLista de alunos e suas notas:");

            foreach (var alunoEntry in aluno)
            {
                string nomeAluno = alunoEntry.Key;
                List<double> notas = alunoEntry.Value;
                double media = CalcularMedia(notas);

                Console.WriteLine($"Aluno: {nomeAluno} - Notas: {string.Join(", ", notas)} - Média: {media}");
            }
        }

        static double CalcularMedia(List<double> notas)
        {
            double soma = 0;

            foreach (var nota in notas)
            {
                soma += nota;
            }

            return soma / notas.Count;
        }
    }
}
