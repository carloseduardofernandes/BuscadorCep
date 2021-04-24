using System;
using BuscadorCep.Domain;

namespace BuscadorCep.Infrastructure
{
    public class ConsultaEnderecoCepWSCorreios: IConsultaEnderecoCep
    {        
        readonly private WSCorreios.AtendeClienteClient atendeClienteClient = new WSCorreios.AtendeClienteClient();
        
        public EnderecoCep ConsultarEnderecoCep(int cep)
        {
            try
            {
                return ConsultaCep(cep.ToString());
            }
            catch (Exception e)
            {
                return CreateEnderecoCepError(cep.ToString(), e.Message);
            }
        }

        private EnderecoCep ConsultaCep(string cep)
        {
            var resposta = atendeClienteClient.consultaCEP(cep);

            if (resposta == null)
            {
                return CreateEnderecoCepError(cep, "Retorno correios null");
            }

            return CreateEnderecoCep(cep, resposta);
        }

        private EnderecoCep CreateEnderecoCep(String cep, WSCorreios.enderecoERP resposta)
        {
            return new EnderecoCep()
            {
                Bairro = resposta.bairro,
                Cep = cep,
                Cidade = resposta.cidade,
                Complemento = resposta.complemento2,
                Logradouro = resposta.end,
                Uf = resposta.uf,
                DataProcessamento = DateTime.Now,
                StatusProcessamento = "OK"
            };
        }

        private EnderecoCep CreateEnderecoCepError(String cep, String message)
        {
            return new EnderecoCep()
            {
                Bairro = "",
                Cep = cep,
                Cidade = "",
                Complemento = "",
                Logradouro = "",
                Uf = "",
                StatusProcessamento = "ERRO",
                DataProcessamento = DateTime.Now,
                ErroProcessamento = $"Erro: {message}"
            };
        }
    }
}
