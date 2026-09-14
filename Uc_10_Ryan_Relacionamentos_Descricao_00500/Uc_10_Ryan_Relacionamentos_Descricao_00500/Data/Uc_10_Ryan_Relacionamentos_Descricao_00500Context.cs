using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Uc_10_Ryan_Relacionamentos_Descricao_00500.Models;

namespace Uc_10_Ryan_Relacionamentos_Descricao_00500.Data
{
    public class Uc_10_Ryan_Relacionamentos_Descricao_00500Context : DbContext
    {
        public Uc_10_Ryan_Relacionamentos_Descricao_00500Context (DbContextOptions<Uc_10_Ryan_Relacionamentos_Descricao_00500Context> options)
            : base(options)
        {
        }

        public DbSet<Uc_10_Ryan_Relacionamentos_Descricao_00500.Models.Consulta> Consulta { get; set; } = default!;
        public DbSet<Uc_10_Ryan_Relacionamentos_Descricao_00500.Models.Medico> Medico { get; set; } = default!;
        public DbSet<Uc_10_Ryan_Relacionamentos_Descricao_00500.Models.Paciente> Paciente { get; set; } = default!;
        public DbSet<Uc_10_Ryan_Relacionamentos_Descricao_00500.Models.TipoConsulta> TipoConsulta { get; set; } = default!;
    }
}
