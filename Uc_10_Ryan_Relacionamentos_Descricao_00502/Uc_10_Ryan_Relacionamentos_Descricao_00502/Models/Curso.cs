using System.ComponentModel.DataAnnotations;

namespace Uc_10_Ryan_Relacionamentos_Descricao_00502.Models
{
    public class Curso
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Nome { get; set; } = string.Empty;

        [Required]
        public int CargaHoraria { get; set; }

        public int ProfessorId { get; set; }

        public Professor? Professor { get; set; }

        public ICollection<Matricula> Matriculas { get; set; }
            = new List<Matricula>();
    }
}
