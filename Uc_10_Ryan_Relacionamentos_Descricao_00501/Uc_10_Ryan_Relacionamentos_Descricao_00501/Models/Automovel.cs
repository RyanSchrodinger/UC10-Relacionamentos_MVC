using System.ComponentModel.DataAnnotations;

namespace Uc_10_Ryan_Relacionamentos_Descricao_00501.Models
{
    public class Automovel
    {
        public int AutomovelId { get; set; }

        [Required(ErrorMessage = "O Modelo é obrigatório.")]
        public string Modelo { get; set; } = string.Empty;

        [Required(ErrorMessage = "A Cor é obrigatória.")]
        public string Cor { get; set; } = string.Empty;

        [Required(ErrorMessage = "O Ano é obrigatório.")]
        public string Ano { get; set; } = string.Empty;

        [Required(ErrorMessage = "A Placa é obrigatória.")]
        public string Placa { get; set; } = string.Empty;

        public int MarcaId { get; set; }

        public Marca? Marca { get; set; }

        public ICollection<Venda> Vendas { get; set; }
            = new List<Venda>();
    }
}
