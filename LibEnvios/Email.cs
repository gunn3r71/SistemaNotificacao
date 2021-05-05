using System;

namespace LibEnvios
{
    public class Email : Notificacao
    {
        public override void Enviar(ConteudoNotificacao conteudo)
        {
            Console.WriteLine($"Enviando email para cliente de código {conteudo.CodCliente}...");
            Console.WriteLine(".....Aguarde");
            Console.WriteLine($"Email enviado: {conteudo.Mensagem}");
            Console.WriteLine("Email Enviado com sucesso");
        }
    }
}
