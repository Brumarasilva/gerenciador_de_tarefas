using System.Security.Cryptography.X509Certificates;
using Microsoft.VisualBasic;
using Tarefas;

namespace GerenciarTarefa

{
    class Gerenciamento
    {
        
        public static List<Tarefa> tarefas =new List<Tarefa>();
        int contadorId = 1;
        public void AdicionarTarefa(string descricao)
        {
            var novaTarefa = new Tarefa(contadorId++, descricao);
            
            tarefas.Add(novaTarefa);

        }
        public static void ListarTarefas()
        {
            Console.WriteLine("ListarTarefas: ");
            foreach (var tarefa in tarefas)
            {
                Console.WriteLine($"Digite a descrição da tarefa:  {tarefas} ");
            }
            
            
        }
        public static void ConcluirTarefa()
        {
            


        }
        public static void RemoverTarefa()
        {
          
            
        }
        public static void Sair()
        {
            
        }
    }

}    