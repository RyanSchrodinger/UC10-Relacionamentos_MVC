using System.ComponentModel.DataAnnotations;

namespace Uc_10_Ryan_Relacionamentos_Descricao_00003.Models
{
    public class Paciente
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(255)]
        public string Nome { get; set; }
        [MaxLength(150)]
        public string? Email { get; set; }

        public int MedicoId { get; set; }

        public virtual Medico? Medico { get; set; }
    }
}
