using DevIO.Business.Notificacoes;
using System;
using System.Collections.Generic;
using System.Text;

namespace DevIO.Business.Interfaces
{
    public interface INotificador
    {
        bool TemNotificacao();
        List<Notificacao> Obternotificacoes();
        void Handle(Notificacao notificacao);
    }
}
