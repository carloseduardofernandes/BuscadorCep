using System.Collections.Generic;

namespace BuscadorCep.Domain.status
{
    public class NotificadorStatusImportacao: INotificadorStatusImportacao
    {
        readonly private List<IObservadorStatusImportacao> importadores;

        public NotificadorStatusImportacao()
        {
            importadores = new List<IObservadorStatusImportacao>();
        }

        public void Registrar(IObservadorStatusImportacao observer)
        {
            importadores.Add(observer);
        }

        public void Remover(IObservadorStatusImportacao observer)
        {
            importadores.Remove(observer);
        }

        public void AtualizarStatusImportacao(ImportadorInfo importadorInfo)
        {
            importadores.ForEach(importador => importador.AtualizaStatusImportacao(importadorInfo));
        }
    }
}
