
using GerenciarTarefa;
using Tarefas;
using Layout;
using System.ComponentModel;
bool opcaoValida = false;
 Console.Clear();
while (true)

{
    var Gerenciamento = new Gerenciamento();

    Formatacao.ImprimirCabecalho();
    Console.WriteLine("1-Adicionar Tarefas");
    Console.WriteLine("2-Listar Tarefa");
    Console.WriteLine("3-Concluir Tarefa");
    Console.WriteLine("4-Remover Tarefa");
    Console.WriteLine("0-Sair");

    do
    {
        Console.WriteLine("Escolha uma opção: ");

        string opcao = Console.ReadLine();
        switch (opcao)
        {
            case "1":
                opcaoValida = true;
                Console.WriteLine("Digite a descrição da tarefa: ");
                string AddTarefa = Console.ReadLine();

                Gerenciamento.AdicionarTarefa(AddTarefa);

                break;
            case "2":
                opcaoValida = true;
                Console.WriteLine("Teste Listar Tarefas");
                Gerenciamento.ListarTarefas();
                break;
            case "3":
                opcaoValida = true;
                Console.WriteLine("Teste Concluir Tarefa");
                Gerenciamento.ConcluirTarefa();
                break;
            case "4":
                opcaoValida = true;
                Console.WriteLine("Teste Remover Tarefa");
                Gerenciamento.RemoverTarefa();
                break;
            case "0":
                opcaoValida = true;
                
                Gerenciamento.Sair();
                return;
                default:
                opcaoValida = false;
                Console.WriteLine("Opção Inválida: Tente Novamente! ");
                break;
        }

    }while(opcaoValida == false);

}





