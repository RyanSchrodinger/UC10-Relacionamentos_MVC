using System.ComponentModel.DataAnnotations;

namespace Uc_10_Ryan_Relacionamentos_Descricao_00502.Models
{
    public class Matricula
    {
        public int Id { get; set; }

        [Required]
        public DateTime DataMatricula { get; set; }

        public int AlunoId { get; set; }

        public Aluno? Aluno { get; set; }

        public int CursoId { get; set; }

        public Curso? Curso { get; set; }
    }
}
