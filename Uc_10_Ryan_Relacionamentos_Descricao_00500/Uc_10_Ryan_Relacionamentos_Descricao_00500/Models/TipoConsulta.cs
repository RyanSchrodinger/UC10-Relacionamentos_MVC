using System.ComponentModel.DataAnnotations;

namespace Uc_10_Ryan_Relacionamentos_Descricao_00500.Models
{
    public class TipoConsulta
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "O campo Nome é obrigatório.")]
        public string Nome { get; set; }
        public  string? Descricao { get; set; }
        [Required(ErrorMessage = "O campo Valor é obrigatório.")]
        public decimal Valor { get; set; } = default(decimal);

        public virtual ICollection<Consulta> Consultas { get; set; } = new List<Consulta>();

    }
}
