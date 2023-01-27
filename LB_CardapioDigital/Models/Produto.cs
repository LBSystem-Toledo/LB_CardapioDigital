namespace LB_CardapioDigital.Models
{
    public class Produto
    {
        public string Cd_produto { get; set; } = string.Empty;
        public string Ds_produto { get; set; } = string.Empty;
        public string Cd_grupo { get; set; } = string.Empty;
        public string Ds_grupo { get; set; } = string.Empty;
        public string Cd_grupo_pai { get; set; } = string.Empty;
        public string Ds_grupo_pai { get; set; } = string.Empty;
        public int OrdemAPP { get; set; }
        public bool PontoCarne { get; set; } = false;
        public bool Adicional { get; set; } = false;
        public bool Ingrediente { get; set; } = false;
        public bool Sabor { get; set; } = false;
        public int Max_sabor { get; set; }
        public int Qt_acompFree { get; set; }
        public string Composicao { get; set; } = string.Empty;
        public bool Obs { get; set; } = false;
        public bool Bloqueado { get; set; } = false;
        public decimal PrecoVenda { get; set; } = decimal.Zero;
    }
}
