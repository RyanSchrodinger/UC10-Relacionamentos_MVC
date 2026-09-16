using System.ComponentModel.DataAnnotations;

namespace Uc_10_Ryan_Relacionamentos_Descricao_00502.Models
{
    using System.ComponentModel.DataAnnotations;

    namespace Uc_10_Ryan_Relacionamentos_Descricao_00501.Models
    {
        public class Curso
        {
            public int Id { get; set; }

            [Required]
            public string Nome { get; set; }

            [Required]
            public int CargaHoraria { get; set; }

            [Required]
            public int ProfessorId { get; set; }

            public Professor Professor { get; set; }

            public ICollection<Matricula> Matriculas { get; set; }
        }
    }
}