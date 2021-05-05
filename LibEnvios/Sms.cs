using System;
namespace LibEnvios
{
    public class Sms : Notificacao  
    {
        public override void Enviar(ConteudoNotificacao conteudo)
        {
            Console.WriteLine($"Enviando mensagem para cliente de código {conteudo.CodCliente}...");
            Console.WriteLine(".....Aguarde");
            Console.WriteLine($"mensagem enviada: {conteudo.Mensagem}");
            Console.WriteLine("mensagem Enviada com sucesso");
        }
    }
}
