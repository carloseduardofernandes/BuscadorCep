using System;

namespace BuscadorCep.Domain
{
    public interface ICacheCep
    {
        void Open();
        bool ContainsKey(int cep);
        void Add(int cep, String statusProcessamento);
    }
}
