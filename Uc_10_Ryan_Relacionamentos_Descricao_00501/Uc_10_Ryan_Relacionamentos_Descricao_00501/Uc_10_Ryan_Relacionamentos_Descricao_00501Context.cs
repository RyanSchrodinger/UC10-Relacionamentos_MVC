using Microsoft.EntityFrameworkCore;

public class Uc_10_Ryan_Relacionamentos_Descricao_00501Context(DbContextOptions<Uc_10_Ryan_Relacionamentos_Descricao_00501Context> options) : DbContext(options)
{
    public DbSet<Uc_10_Ryan_Relacionamentos_Descricao_00501.Models.Automovel> Automovel { get; set; } = default!;
}
