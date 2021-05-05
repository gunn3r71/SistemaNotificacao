using System;
using System.Collections.Generic;
using System.Text;

namespace LibEnvios
{
    public abstract class Notificacao
    {
        public abstract void Enviar(ConteudoNotificacao conteudo);
    }
}
