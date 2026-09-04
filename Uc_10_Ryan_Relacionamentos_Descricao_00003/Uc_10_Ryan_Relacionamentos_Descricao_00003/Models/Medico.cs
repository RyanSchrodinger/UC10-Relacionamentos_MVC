using System.ComponentModel.DataAnnotations;

namespace Uc_10_Ryan_Relacionamentos_Descricao_00003.Models
{
    public class Medico
    {
        [Key]
        public int MedicoId { get; set; }

        [Required]
        [MaxLength(100)]
        public string Nome { get; set; }

        [Required]
        [MaxLength(150)]
        public string? CRM { get; set; }

        public int EspecialidadeId { get; set; }

        public virtual Especialidade? Especialidade { get; set; }

        public virtual ICollection<Paciente> Pacientes { get; set; } = new List<Paciente>();
    }
}
