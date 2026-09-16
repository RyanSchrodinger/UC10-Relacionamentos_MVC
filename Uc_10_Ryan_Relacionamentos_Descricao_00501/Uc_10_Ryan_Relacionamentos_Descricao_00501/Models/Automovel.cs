using System.ComponentModel.DataAnnotations;

namespace Uc_10_Ryan_Relacionamentos_Descricao_00501.Models
{
    public class Automovel
    {
        public int AutomovelId { get; set; }
        [Required(ErrorMessage = "O Modelo é obrigatório.")]
        public string Modelo { get; set; }

        [Required(ErrorMessage = "A Cor é obrigatória.")]
        public string Cor { get; set; }

        [Required(ErrorMessage = "O Ano é obrigatório.")]
        public string Ano { get; set; }

        [Required(ErrorMessage = "A Placa é obrigatória.")]
        public string Placa { get; set; }

        public int MarcaId { get; set; }
        public Marca Marca { get; set; } 
    }
}
