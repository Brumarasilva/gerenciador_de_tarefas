using System.Data.Common;

namespace Tarefas
{
    class Tarefa

    {
         public int Id{get; set;}//Um número inteiro que identifica a tarefa de forma única. Cada tarefa tem um ID diferente.

        public string Descricao {get; set;}// Um texto que descreve o que a tarefa é (por exemplo, "Estudar C#").
        public bool Concluida {get; set;}//Um valor booleano (true ou false) que indica se a tarefa foi concluída ou não.
       
       public Tarefa (int id, string descricao)//é um método especial usado para criar um objeto da classe Tarefa. Ele define os valores iniciais para as propriedades Id e Descricao quando a tarefa é criada.
       {
        Id = id;//Inicializam as propriedades com os valores passados quando a tarefa for criada.
        Descricao = descricao;//Inicializam as propriedades com os valores passados quando a tarefa for criada.
        Concluida = false;//Define que a tarefa começa como não concluída (false).
       }
       


        

    }

}
