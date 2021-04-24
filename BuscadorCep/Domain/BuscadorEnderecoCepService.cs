using BuscadorCep.Domain;
using BuscadorCep.Domain.status;
using System.Collections.Generic;
using System.Linq;

namespace BuscadorCep.Infrastructure
{
    public class BuscadorEnderecoCepService
    {
        readonly private IImportadorFaixaCep importadorFaixaCep;
        readonly private IExtratorCepDaFaixa extratorCepDaFaixa;
        readonly private ICacheCep cacheCep;
        readonly private IConsultaEnderecoCep consultaEnderecoCep;
        readonly private IExportadorEnderecoCep exportadorEnderecoCep;                
        readonly private INotificadorStatusImportacao notificadorStatusImportacao;
        readonly private ImportadorInfo importadorInfo;

        public BuscadorEnderecoCepService(IImportadorFaixaCep importadorFaixaCep, 
                                   IExtratorCepDaFaixa extratorCepDaFaixa,
                                   ICacheCep cacheCep,
                                   IConsultaEnderecoCep consultaEnderecoCep,
                                   IExportadorEnderecoCep exportadorEnderecoCep)
        {
            this.importadorFaixaCep = importadorFaixaCep;
            this.extratorCepDaFaixa = extratorCepDaFaixa;
            this.cacheCep = cacheCep;
            this.consultaEnderecoCep = consultaEnderecoCep;
            this.exportadorEnderecoCep = exportadorEnderecoCep;                        
            this.notificadorStatusImportacao = new NotificadorStatusImportacao();
            this.importadorInfo = new ImportadorInfo();
        }

        public void ExtrairCepsDosCorreios(string arquivoDeOrigem)
        {
            List<FaixaCep> faixas = importadorFaixaCep.ImportarDoArquivo(arquivoDeOrigem);

            cacheCep.Open();

            InicializaQuantidadeRegistrosImportacao(faixas);

            faixas.ForEach(faixa => ExportarFaixa(faixa));
        }

        private void InicializaQuantidadeRegistrosImportacao(List<FaixaCep> faixas)
        {
            importadorInfo.QuantidadeRegistros = faixas
                            .Select(faixa => faixa.GetQuantidadeCeps())
                            .Aggregate((acc, x) => acc + x);            
        }

        private void ExportarFaixa(FaixaCep faixa)
        {            
            var ceps = extratorCepDaFaixa.Extrair(faixa);
            ExportarCeps(ceps);
        }

        private void ExportarCeps(List<int> ceps)
        {
            ceps.ForEach(cep => ExportarCep(cep));
        }

        private void ExportarCep(int cep)
        {
            if (!cacheCep.ContainsKey(cep))
            {
                var endereco = consultaEnderecoCep.ConsultarEnderecoCep(cep);

                exportadorEnderecoCep.Exportar(endereco);

                cacheCep.Add(cep, endereco.StatusProcessamento);
            }

            AtualizarStatusENotificar();
        }

        private void AtualizarStatusENotificar()
        {
            importadorInfo.IncrementarQuantidade();
            notificadorStatusImportacao.AtualizarStatusImportacao(importadorInfo);
        }

        public INotificadorStatusImportacao NotificadorStatusImportacao()
        {
            return notificadorStatusImportacao;
        }
    }
}
