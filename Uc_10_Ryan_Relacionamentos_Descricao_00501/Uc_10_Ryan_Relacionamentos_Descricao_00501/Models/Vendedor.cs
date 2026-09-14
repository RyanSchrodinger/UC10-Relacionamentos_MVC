using System.ComponentModel.DataAnnotations;

namespace Uc_10_Ryan_Relacionamentos_Descricao_00501.Models
{
    public class Vendedor
    {
        public int VendedorId { get; set; }
        [Required(ErrorMessage = "O Nome é obrigatório.")]
        public string Nome { get; set; }
        public string Cpf { get; set; }
    }
}
