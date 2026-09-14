namespace Uc_10_Ryan_Relacionamentos_Descricao_00500.Models
{
    public class Consulta
    {
        public  int ConsultaId { get; set; }
        public int TipoConsultaId { get; set; }
        public TipoConsulta? TipoConsulta { get; set; }

        public Paciente? Paciente { get; set; }
        public Medico? Medico { get; set; } 
        public int PacienteId { get; set; }
        public int MedicoId { get; set; }


    }
}
