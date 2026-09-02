using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Uc_10_Ryan_Relacionamentos_Codigo_00003.Models;

namespace Uc_10_Ryan_Relacionamentos_Codigo_00003.Data
{
    public class Uc_10_Ryan_Relacionamentos_Codigo_00003Context : DbContext
    {
        public Uc_10_Ryan_Relacionamentos_Codigo_00003Context (DbContextOptions<Uc_10_Ryan_Relacionamentos_Codigo_00003Context> options)
            : base(options)
        {
        }

        public DbSet<Uc_10_Ryan_Relacionamentos_Codigo_00003.Models.Especialidade> Especialidade { get; set; } = default!;
        public DbSet<Uc_10_Ryan_Relacionamentos_Codigo_00003.Models.Medico> Medico { get; set; } = default!;
        public DbSet<Uc_10_Ryan_Relacionamentos_Codigo_00003.Models.Paciente> Paciente { get; set; } = default!;
    }
}
