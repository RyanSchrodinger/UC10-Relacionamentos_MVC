using System.ComponentModel.DataAnnotations;
using Uc_10_Ryan_Relacionamentos_Descricao_00502.Models.Uc_10_Ryan_Relacionamentos_Descricao_00501.Models;

namespace Uc_10_Ryan_Relacionamentos_Descricao_00502.Models
{
    public class Matricula
    {
        public int Id { get; set; }

        [Required]
        public DateTime DataMatricula { get; set; }

        [Required]
        public int AlunoId { get; set; }

        public Aluno Aluno { get; set; }

        [Required]
        public int CursoId { get; set; }

        public Curso Curso { get; set; }
    }
}
