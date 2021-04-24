namespace BuscadorCep.Domain
{
    public interface INotificadorStatusImportacao
    {
        void Registrar(IObservadorStatusImportacao observer);
        void Remover(IObservadorStatusImportacao observer);
        void AtualizarStatusImportacao(ImportadorInfo importadorInfo);

    }
}
