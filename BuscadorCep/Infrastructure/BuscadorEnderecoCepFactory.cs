using BuscadorCep.Domain;
using BuscadorCep.Infrastructure.cache;

namespace BuscadorCep.Infrastructure
{
    class BuscadorEnderecoCepFactory
    {
        public BuscadorEnderecoCepFactory()
        {
            //fazer DI injecao de dependencia testar
        }

        public static BuscadorEnderecoCepService GetBuscadorEnderecoCepConsoleOutput()
        {            
            return new BuscadorEnderecoCepService(
                            new ImportadorFaixaCepExcel(),
                            new ExtratorCepDaFaixa(),
                            new PersistentCacheCep(),
                            new ConsultaEnderecoCepWSCorreios(),
                            new ExportadorEnderecoCepConsole()
                        );
        }

        public static BuscadorEnderecoCepService GetBuscadorEnderecoCepExcel(string outputFile)
        {
            return new BuscadorEnderecoCepService(
                            new ImportadorFaixaCepExcel(),
                            new ExtratorCepDaFaixa(),
                            new PersistentCacheCep(),
                            new ConsultaEnderecoCepWSCorreios(),
                            new ExportadorEnderecoCepExcel(outputFile)
                        );
        }
    }
}
