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

            Console.WriteLine($"Enviando email para cliente de código {codCliente}...");
            Console.WriteLine(".....Aguarde");
            Console.WriteLine($"Email enviado: {mensagem}");
            Console.WriteLine("Email Enviado com sucesso");
        }
    }
}
