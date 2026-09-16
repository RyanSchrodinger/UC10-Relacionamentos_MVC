using System.ComponentModel.DataAnnotations;

namespace Uc_10_Ryan_Relacionamentos_Descricao_00502.Models
{
    public class Aluno
    {
        public int Id { get; set; }

        [Required]
        public string Nome { get; set; }

        [Required]
        public string Email { get; set; }

        public ICollection<Matricula> Matriculas { get; set; }
    }
}