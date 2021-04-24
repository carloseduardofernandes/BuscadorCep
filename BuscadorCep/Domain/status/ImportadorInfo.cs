
namespace BuscadorCep.Domain
{
    public class ImportadorInfo
    {
        public int QuantidadeRegistros { get; set; } = 0 ;
        public int QuantidadeProcessados { get; set; } = 0;

        public void IncrementarQuantidade()
        {
            this.QuantidadeProcessados++;
        }
    }
}
