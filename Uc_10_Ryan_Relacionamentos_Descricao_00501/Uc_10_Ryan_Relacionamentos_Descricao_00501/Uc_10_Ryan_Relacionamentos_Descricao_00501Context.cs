using Microsoft.EntityFrameworkCore;
using Uc_10_Ryan_Relacionamentos_Descricao_00501.Models;

public class Uc_10_Ryan_Relacionamentos_Descricao_00501Context(DbContextOptions<Uc_10_Ryan_Relacionamentos_Descricao_00501Context> options) : DbContext(options)
{
    public DbSet<Uc_10_Ryan_Relacionamentos_Descricao_00501.Models.Automovel> Automovel { get; set; } = default!;

public DbSet<Uc_10_Ryan_Relacionamentos_Descricao_00501.Models.Cliente> Cliente { get; set; } = default!;

public DbSet<Uc_10_Ryan_Relacionamentos_Descricao_00501.Models.Marca> Marca { get; set; } = default!;

public DbSet<Uc_10_Ryan_Relacionamentos_Descricao_00501.Models.Venda> Venda { get; set; } = default!;

public DbSet<Uc_10_Ryan_Relacionamentos_Descricao_00501.Models.Vendedor> Vendedor { get; set; } = default!;
}
