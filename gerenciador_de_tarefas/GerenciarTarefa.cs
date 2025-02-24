using System.Security.Cryptography.X509Certificates;
using Layout;
using Microsoft.VisualBasic;
using Tarefas;

namespace GerenciarTarefa

{
    class Gerenciamento
    //
    {

        public static List<Tarefa> tarefas = new List<Tarefa>();//esse código tem a função de criar a lista de tarefas (porém ela vai estar vazia ela vai aprecendo conforme o usuário adiciona no arquivo indivisual) 
        private static int contadorId = 1; //essa função toda vez que o usuário adicionar uma tarefa vai ser listada do 1 adiante
        public void AdicionarTarefa(string descricao)// Adicionar tarefa é o nome do método e o parâmetro descrição(string), que será a descrição da tarefa a ser adicionada na hora que tiver rodando o programa vai te pedir pra adicionar uma ou mais tarefas dependendo de quantas for adicionar.
        {
            var novaTarefa = new Tarefa(contadorId++, descricao); //ao adicionar uma nova tarefa essas tarefas serão numeradas.

            tarefas.Add(novaTarefa);
            Formatacao.Cor("Tarefa adicionada com sucesso! ", ConsoleColor.Green); //de acordo com a frase ou letra colocada dentro do parentese com aspas duplas o programa vai mudar ela de cor.

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