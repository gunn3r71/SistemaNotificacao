using LibEnvios;
using SistemaNotificacao.Enums;
using System;

namespace SistemaNotificacao
{
    class Program
    {
        private static Notificacao notificacao;
        static void Main(string[] args)
        {
            Console.WriteLine("####Sistema de notificação####");
            Console.Write("Digite o código do cliente: ");
            var codCliente = Console.ReadLine();
            Console.Write("Digite a mensagem a ser enviada: ");
            var mensagem = Console.ReadLine();
            Console.WriteLine("Tipo de mensagem a ser enviada:\n1 Para Email\n2 Para Mensagem de texto");
            var opcao = Console.ReadLine();

            var modoEnvio = (ModoEnvio)Enum.Parse(typeof(ModoEnvio), opcao);
            switch (modoEnvio)
            {
                case ModoEnvio.Email:
                    notificacao = new Email();
                    break;
                case ModoEnvio.Sms:
                    notificacao = new Sms();
                    break;
                default:
                    break;
            }

            notificacao.Enviar(new ConteudoNotificacao { CodCliente = codCliente, Mensagem = mensagem});
        }
    }
}