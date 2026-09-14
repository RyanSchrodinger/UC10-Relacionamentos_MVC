using System.ComponentModel.DataAnnotations;

namespace Uc_10_Ryan_Relacionamentos_Descricao_00500.Models
{
    public class Medico
    {
        [Key]
        public int MedicoId { get; set; }

        [Required(ErrorMessage = "O campo Nome é obrigatório.")]
        [MaxLength(100)]
        public string Nome { get; set; }

        [Required]
        [MaxLength(150)]
        public string? CRM { get; set; }

        [Required(ErrorMessage = "O campo Especialidade é obrigatório.")]
        public string Especialidade { get; set; }

        public virtual ICollection<Consulta> Consultas { get; set; } = new List<Consulta>();
    }
}
