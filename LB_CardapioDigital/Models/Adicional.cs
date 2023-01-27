namespace LB_CardapioDigital.Models
{
    public class Adicional
    {
        public int Id_adicional { get; set; }
        public int Id_grupo { get; set; }
        public string Cd_adicional { get; set; } = string.Empty;
        public string Ds_adicional { get; set; } = string.Empty;
        public decimal Quantidade { get; set; } = decimal.Zero;
        public decimal PrecoVenda { get; set; } = decimal.Zero;
    }
}
