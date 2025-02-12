using System.Data.Common;

namespace Tarefas
{
    class Tarefa

    {
         public int Id{get; set;}

        public string Descricao {get; set;}
        public bool Concluida {get; set;}
       
       public Tarefa (int id, string descricao)
       {
        Id = id;
        Descricao = descricao;
        Concluida = false;
       }


        

    }

}
