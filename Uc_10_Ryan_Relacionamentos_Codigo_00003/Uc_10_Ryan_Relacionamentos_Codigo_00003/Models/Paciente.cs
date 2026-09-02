using System.ComponentModel.DataAnnotations;

namespace Uc_10_Ryan_Relacionamentos_Codigo_00003.Models
{
    public class Paciente
    {
        [Key]
        public int PacienteId { get; set; }

        [Required]
        [MaxLength(100)]
        public string Nome { get; set; }

        [MaxLength(150)]
        public string? Email { get; set; }

        public int MedicoId { get; set; }

        public Medico? Medico { get; set; }
    }
}
