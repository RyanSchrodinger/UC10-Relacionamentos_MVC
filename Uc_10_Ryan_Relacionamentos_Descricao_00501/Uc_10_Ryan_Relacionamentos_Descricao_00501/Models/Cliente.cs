using System.ComponentModel.DataAnnotations;

namespace Uc_10_Ryan_Relacionamentos_Descricao_00501.Models
{
    public class Cliente
    {
        public int ClienteId { get; set; }

        [Required(ErrorMessage = "O Nome é obrigatório.")]
        public string Nome { get; set; }
        public string Email { get;set; }
        public string Cpf { get; set; }
    }
}
