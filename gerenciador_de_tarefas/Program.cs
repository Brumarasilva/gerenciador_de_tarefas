
using GerenciarTarefa;
using Tarefas;
using Layout;
using System.ComponentModel;

Formatacao.ImprimirCabecalho();
// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// Formatacao.Cor("hello, World!", ConsoleColor.Yellow);
Console.WriteLine("1-Adicionar Tarefas");
Console.WriteLine("2-Listar Tarefa");
Console.WriteLine("3-Concluir Tarefa");
Console.WriteLine("4-Remover Tarefa");
Console.WriteLine("0-Sair");
Console.WriteLine("Escolha uma opção: ");

string opcao = Console.ReadLine();
switch (opcao)
{
    case "1":
        Console.WriteLine("Digite a descrição da tarefa: ");
        string AddTarefa = Console.ReadLine();

        Gerenciamento.AdicionarTarefa(AddTarefa);

        break;
    case "2":
        Console.WriteLine("Teste Listar Tarefas");
        Gerenciamento.ListarTarefas();
        break;
    case "3":
        Console.WriteLine("Teste Concluir Tarefa");
        Gerenciamento.ConcluirTarefa();
        break;
    case "4":
        Console.WriteLine("Teste Remover Tarefa");
        Gerenciamento.RemoverTarefa();
        break;
    case "5":
        Console.WriteLine("Sair");
        Gerenciamento.Sair();
        break;

}





