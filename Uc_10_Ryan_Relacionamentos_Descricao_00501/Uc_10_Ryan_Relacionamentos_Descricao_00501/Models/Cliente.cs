using System.ComponentModel.DataAnnotations;

namespace Uc_10_Ryan_Relacionamentos_Descricao_00501.Models
{
    public class Cliente
    {
        public int ClienteId { get; set; }

        [Required(ErrorMessage = "O Nome é obrigatório.")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "O Email é obrigatório.")]
        public string Email { get;set; }
        [Required(ErrorMessage = "O Cpf é obrigatório.")]
        public string Cpf { get; set; }
    }
}
