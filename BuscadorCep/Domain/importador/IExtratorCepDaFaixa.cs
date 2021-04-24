using System.Collections.Generic;

namespace BuscadorCep.Domain
{
    public interface IExtratorCepDaFaixa
    {
        List<int> Extrair(FaixaCep faixa);
    }
}
