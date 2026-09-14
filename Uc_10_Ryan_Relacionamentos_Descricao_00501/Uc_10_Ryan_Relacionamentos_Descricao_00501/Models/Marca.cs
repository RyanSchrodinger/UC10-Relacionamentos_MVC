using System.ComponentModel.DataAnnotations;

namespace Uc_10_Ryan_Relacionamentos_Descricao_00501.Models
{
    public class Marca
    {
        public int MarcaId { get; set; }
        [Required(ErrorMessage = "O Nome da Marca é obrigatório.")]
        public string Nome { get; set; }

        public ICollection<Automovel> Automoveis { get; set; } = new List<Automovel>();
    }
}
