using System.Drawing;

namespace Layout
{
    class Formatacao
    {
        public static void Cor(string mensagem, ConsoleColor cor)//ao criar esse metódo formatacao.Cor quando o usuário quiser mudar a cor de uma descrição ele vai usar esse metódo ao inves de utilizar Console.WriteLine.
        {
            Console.ForegroundColor = cor;
            Console.WriteLine(mensagem);
            Console.ResetColor();
        }

        public static void ImprimirCabecalho()//Esse cabeçalho vai ser impresso quando o programa estiver rodando.
        {
            Console.WriteLine("╔════════════════════════╗");
            Console.WriteLine("║ GERENCIADOR DE TAREFAS ║");
            Console.WriteLine("╚════════════════════════╝");
        }

    }
}