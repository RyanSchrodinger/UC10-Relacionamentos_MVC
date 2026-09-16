using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Uc_10_Ryan_Relacionamentos_Descricao_00502.Models;

namespace Uc_10_Ryan_Relacionamentos_Descricao_00502.Data
{
    public class Uc_10_Ryan_Relacionamentos_Descricao_00502Context : DbContext
    {
        public Uc_10_Ryan_Relacionamentos_Descricao_00502Context (DbContextOptions<Uc_10_Ryan_Relacionamentos_Descricao_00502Context> options)
            : base(options)
        {
        }

        public DbSet<Uc_10_Ryan_Relacionamentos_Descricao_00502.Models.Aluno> Aluno { get; set; } = default!;
        public DbSet<Uc_10_Ryan_Relacionamentos_Descricao_00502.Models.Curso> Curso { get; set; } = default!;
        public DbSet<Uc_10_Ryan_Relacionamentos_Descricao_00502.Models.Matricula> Matricula { get; set; } = default!;
        public DbSet<Uc_10_Ryan_Relacionamentos_Descricao_00502.Models.Professor> Professor { get; set; } = default!;
    }
}
