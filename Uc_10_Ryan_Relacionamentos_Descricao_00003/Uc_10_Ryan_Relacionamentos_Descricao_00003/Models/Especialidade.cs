using System.ComponentModel.DataAnnotations;

namespace Uc_10_Ryan_Relacionamentos_Descricao_00003.Models
{
    public class Especialidade
    {
        [Key]
        public int EspecialidadeId { get; set; }
        [Required]
        [MaxLength(100)]
        public string Nome { get; set; }
        public virtual ICollection<Medico> Medicos { get; set; } = new List<Medico>();
    }
}
