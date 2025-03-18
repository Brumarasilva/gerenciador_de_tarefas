
using GerenciarTarefa;
using Tarefas;
using Layout;
using System.ComponentModel;
bool opcaoValida = false;//inicializa a variavel de controle
 Console.Clear();//limpa o programa para o usuário escrever
while (true)//logo de repetição para garantir que a opção seja validada.

{
    var Gerenciamento = new Gerenciamento();

    Formatacao.ImprimirCabecalho(); //Quando o usuário colocar o código para rodar, o programa vai imprimir o cabeçalho fornecido pelo usuário.
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
                string AddTarefa = Console.ReadLine();// O usuário digita a descrição da tarefa

                Gerenciamento.AdicionarTarefa(AddTarefa);

                break;
            case "2":
                opcaoValida = true;
                Console.WriteLine("Teste Listar Tarefas");//O usuário vai listar as tarefas
                Gerenciamento.ListarTarefas();
                break;
            case "3":
                opcaoValida = true;
                Console.WriteLine("Teste Concluir Tarefa");//O usuário vai terminar e marcar como concluida.
                Gerenciamento.ConcluirTarefa();
                break;
            case "4":
                opcaoValida = true;
                Console.WriteLine("Teste Remover Tarefa");
                Gerenciamento.RemoverTarefa();//O usuário vai remover a tarefa
                break;
            case "0":
                opcaoValida = true;
                
                Gerenciamento.Sair(); //O usuário vai sair do programa
                return;//Encerra o programa
                default:
                opcaoValida = false;
                Console.WriteLine("Opção Inválida: Tente Novamente! ");
                break;
        }

    }while(opcaoValida == false); // Continua pedindo até que uma opção válida seja escolhida

}





