using ProjetoModeloDDDContext.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoModeloDDDContext.Infra.Data.EntityConfig
{
    public class UsuarioConfiguration : EntityTypeConfiguration<Usuario>
    {
        public UsuarioConfiguration()
        {
            HasKey(u => u.UsuarioId);
            Property(u => u.Nome)
                .IsRequired()
                .HasMaxLength(150);

            Property(u => u.Email)
                .IsRequired();
        }
    }
}
