using System;

namespace LibEnvios
{
    public class Email
    {
        public static void Enviar(int codCliente,string mensagem)
        {
            Console.WriteLine($"Enviando email para cliente de código {codCliente}...");
            Console.WriteLine(".....Aguarde");
            Console.WriteLine($"Email enviado: {mensagem}");
            Console.WriteLine("Email Enviado com sucesso");
        }
    }
}
