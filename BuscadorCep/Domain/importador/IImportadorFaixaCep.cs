using System.Collections.Generic;

namespace BuscadorCep.Domain
{
    public interface IImportadorFaixaCep
    {
        List<FaixaCep> ImportarDoArquivo(string filePath);
    }
}
