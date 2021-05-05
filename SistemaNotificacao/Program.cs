using LibEnvios;
using System;

namespace SistemaNotificacao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("####Sistema de notificação####");
            Console.Write("Digite o código do cliente: ");
            int codCliente = int.Parse(Console.ReadLine());
            Console.Write("Digite a mensagem a ser enviada: ");
            string mensagem = Console.ReadLine();
            Console.WriteLine("Tipo de mensagem a ser enviada:\n1 Para Email\n2 Para Mensagem de texto");
            int opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    Email.Enviar(codCliente, mensagem);
                    break;
                case 2:
                    Sms.Enviar(codCliente, mensagem);
                    break;
                default:
                    break;
            }

        }
    }
}
