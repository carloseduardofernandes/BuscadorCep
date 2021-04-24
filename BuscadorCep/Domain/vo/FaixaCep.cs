
namespace BuscadorCep.Domain
{
    public class FaixaCep
    {
        public string Faixa { get; set; }
        public string Inicial { get; set; }
        public string Final { get; set; }

        public int GetQuantidadeCeps()
        {
            var inicial = GetInicio();
            var final = GetFim() + 1;

            if (final < inicial)
            {
                return 1;
            }

            return final - inicial;
        }

        private int GetFim()
        {
            return int.Parse(Final);
        }

        public int GetInicio()
        {
            return int.Parse(Inicial);
        }
    }
}
