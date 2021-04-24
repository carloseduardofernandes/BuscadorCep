
using System;

namespace BuscadorCep.Domain
{        
    public class EnderecoCep
    {
        public string Bairro { get; set; }
        
        public string Cep { get; set; }
        
        public string Cidade { get; set; }
        
        public string Complemento { get; set; }
        
        public string Logradouro { get; set; }
        
        public string Uf { get; set; }

        public DateTime DataProcessamento { get; set; }

        public string StatusProcessamento { get; set; }

        public string ErroProcessamento { get; set; }
    }
}
