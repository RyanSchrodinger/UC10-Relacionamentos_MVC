namespace Uc_10_Ryan_Relacionamentos_Descricao_00501.Models
{
    public class Venda
    {
        public int VendaId { get; set; }
        public int ClienteId { get; set; }
        public int VendedorId { get; set; }
        public int AutomovelId { get; set; }
        public DateTime DataVenda { get; set; }
        public decimal ValorVenda { get; set; }
        // Navigation properties
        public Cliente Cliente { get; set; }
        public Vendedor Vendedor { get; set; }
        public Automovel Automovel { get; set; }
    }
}
