using System;
using System.Collections.Generic;
using System.Text;

namespace LibEnvios
{
    public class Sms
    {
        public static void Enviar(int codCliente, string mensagem)
        {
            Console.WriteLine($"Enviando mensagem para cliente de código {codCliente}...");
            Console.WriteLine(".....Aguarde");
            Console.WriteLine($"mensagem enviada: {mensagem}");
            Console.WriteLine("mensagem Enviada com sucesso");
        }
    }
}
