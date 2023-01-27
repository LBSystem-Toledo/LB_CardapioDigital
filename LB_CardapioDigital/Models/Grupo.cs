using LB_CardapioDigital.Pages;

namespace LB_CardapioDigital.Models
{
    public class Grupo
    {
        public string Cd_grupo { get; set; } = string.Empty;
        public string Ds_grupo { get; set; } = string.Empty;
        public IEnumerable<Produto> Produtos { get; set; } = Enumerable.Empty<Produto>();
    }
}
