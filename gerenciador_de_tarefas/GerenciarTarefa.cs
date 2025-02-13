using System.Security.Cryptography.X509Certificates;
using Layout;
using Microsoft.VisualBasic;
using Tarefas;

namespace GerenciarTarefa

{
    class Gerenciamento
    {

        public static List<Tarefa> tarefas = new List<Tarefa>();
        private static int contadorId = 1;
        public void AdicionarTarefa(string descricao)
        {
            var novaTarefa = new Tarefa(contadorId++, descricao);

            tarefas.Add(novaTarefa);
            Formatacao.Cor("Tarefa adicionada com sucesso! ", ConsoleColor.Green);

        }
        public static void ListarTarefas()
        {

            Console.WriteLine("Tarefas: ");
            foreach (var tarefa in tarefas)
            {
                Formatacao.Cor($"{(tarefa.Concluida ? "[x]" : "[ ]")} ID: {tarefa.Id} - {tarefa.Descricao}", ConsoleColor.Yellow);

            }


        }
        public static void ConcluirTarefa()
        {
            {
                Console.Write("Digite o ID da tarefa que deseja concluir: ");

                // Lendo o ID do usuário
                if (int.TryParse(Console.ReadLine(), out int idTarefa))
                {
                    // Agora a busca está correta
                    Tarefa tarefa = tarefas.FirstOrDefault(t => t.Id == idTarefa);

                    if (tarefa != null)
                    {
                        tarefa.Concluida = true;
                        Formatacao.Cor($"Tarefa '{tarefa.Descricao}' foi concluída!", ConsoleColor.Green);
                    }
                    else
                    {
                        Console.WriteLine("Tarefa não encontrada.");
                    }
                }
                else
                {
                    Console.WriteLine("ID inválido. Digite um número válido.");
                }
            }



        }
        public static void RemoverTarefa()
        {
            {
                Console.Write("Digite o ID da tarefa que deseja remover: ");

                // Lendo o ID do usuário
                if (int.TryParse(Console.ReadLine(), out int idTarefa))
                {
                    Tarefa RemoverTarefa = tarefas.FirstOrDefault(t => t.Id == idTarefa);

                    if (RemoverTarefa != null)
                    {
                        tarefas.Remove(RemoverTarefa);
                        Formatacao.Cor($"Tarefa '{RemoverTarefa.Descricao}' removida com sucesso!", ConsoleColor.Red);
                    }
                    else
                    {
                        Console.WriteLine("Tarefa não encontrada.");
                    }
                }
                else
                {
                    Console.WriteLine("ID inválido. Digite um número válido.");
                }
            }


        }
        public static void Sair()
        {
            Formatacao.Cor("Saindo...", ConsoleColor.Red);
        }
    }

}