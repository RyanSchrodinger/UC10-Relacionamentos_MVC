using System.ComponentModel.DataAnnotations;

namespace Uc_10_Ryan_Relacionamentos_Descricao_00500.Models
{
    public class Paciente
    {
        [Key]
        public int PacienteId { get; set; }

        [Required(ErrorMessage = "O campo Nome é obrigatório.")]
        [MaxLength(100)]
        public string Nome { get; set; }

        [MaxLength(150)]
        public string? Email { get; set; }

        public virtual ICollection<Consulta> Consultas { get; set; } = new List<Consulta>();
    }
}
