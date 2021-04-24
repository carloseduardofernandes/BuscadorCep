using System.Collections.Generic;
using System.Linq;

namespace BuscadorCep.Domain
{
    public class ExtratorCepDaFaixa: IExtratorCepDaFaixa
    {        
        public List<int> Extrair(FaixaCep faixa)
        {
            return Enumerable
                .Range(faixa.GetInicio(), faixa.GetQuantidadeCeps())
                .ToList();
        }
    }
}
