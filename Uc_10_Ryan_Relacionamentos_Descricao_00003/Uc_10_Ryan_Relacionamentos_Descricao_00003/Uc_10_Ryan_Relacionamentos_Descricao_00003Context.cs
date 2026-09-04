using Microsoft.EntityFrameworkCore;

public class Uc_10_Ryan_Relacionamentos_Descricao_00003Context(DbContextOptions<Uc_10_Ryan_Relacionamentos_Descricao_00003Context> options) : DbContext(options)
{
    public DbSet<Uc_10_Ryan_Relacionamentos_Descricao_00003.Models.Especialidade> Especialidade { get; set; } = default!;
    public DbSet<Uc_10_Ryan_Relacionamentos_Descricao_00003.Models.Medico> Medico { get; set; } = default!;
    public DbSet<Uc_10_Ryan_Relacionamentos_Descricao_00003.Models.Paciente> Paciente { get; set; } = default!;
}
