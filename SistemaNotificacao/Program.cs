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
                    Console.WriteLine($"Enviando email para cliente de código {codCliente}...");
                    Console.WriteLine(".....Aguarde");
                    Console.WriteLine($"Email enviado: {mensagem}");
                    Console.WriteLine("Email Enviado com sucesso");
                    break;
                case 2:
                    Console.WriteLine($"Enviando mensagem para cliente de código {codCliente}...");
                    Console.WriteLine(".....Aguarde");
                    Console.WriteLine($"mensagem enviada: {mensagem}");
                    Console.WriteLine("mensagem Enviada com sucesso");
                    break;
                default:
                    break;
            }

        }
    }
}
