using System;
using BuscadorCep.Domain;

namespace BuscadorCep.Infrastructure
{    
    public class ExportadorEnderecoCepConsole: IExportadorEnderecoCep
    {
        public void Exportar(EnderecoCep enderecoCepDto)
        {
            Console.WriteLine(enderecoCepDto.Cep + " - " + enderecoCepDto.DataProcessamento);
        }        
    }
}
