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

            Console.WriteLine("Tarefas: ");//o Console.WriteLine vai imprimir a mensagem para o usuário na hora que estiver rodando
            foreach (var tarefa in tarefas)
            {
                Formatacao.Cor($"{(tarefa.Concluida ? "[x]" : "[ ]")} ID: {tarefa.Id} - {tarefa.Descricao}", ConsoleColor.Yellow);//Na hora que estiver rodando caso a tarefa estiver concluida o usuário vai avisar e o programa vai marcar um[x](Concluida) caso contrário [](Pendente). A Formatacao.Cor serva para que caso o usuário queira imprimir a mensagem com cor diferente.

            }


        }
        public static void ConcluirTarefa()
        {
            {
                Console.Write("Digite o ID da tarefa que deseja concluir: ");//o Console.WriteLine vai imprimir a mensagem para o usuário na hora que estiver rodando

                // Lendo o ID do usuário
                if (int.TryParse(Console.ReadLine(), out int idTarefa))//essa parte vai permitir que, na hora que o código estiver rodando, o usuário consiga escrever as tarefas, e com isso elas vão ser numeradas.
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
                Console.Write("Digite o ID da tarefa que deseja remover: ");// aqui o Console.Write imprime a mensagem para aparecer na hora de rodar para o usuário e ele responder

                // Lendo o ID do usuário
                if (int.TryParse(Console.ReadLine(), out int idTarefa))// caso o id seja válido o programa vai salvar a informação dentro desse código
                {
                    Tarefa RemoverTarefa = tarefas.FirstOrDefault(t => t.Id == idTarefa);//o programa vai buscar a tarefa com o id(número) que o usuário informou e caso encontrado ele vai salvar dentro da variável RemoverTarefa e a tarefa vai ser removida.

                    if (RemoverTarefa != null)// neste caso se o programa buscar a tarefa selecionada pelo usuário vai dar nulo ou inválido.
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