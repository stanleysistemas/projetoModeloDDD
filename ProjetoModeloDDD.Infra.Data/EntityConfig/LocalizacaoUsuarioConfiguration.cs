using ProjetoModeloDDD.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace ProjetoModeloDDD.Infra.Data.EntityConfig
{
    public class LocalizacaoUsuarioConfiguration : EntityTypeConfiguration<LocalizacaoUsuario>
    {
        public LocalizacaoUsuarioConfiguration()
        {
            HasKey(l => l.LocalizacaoId);

            HasRequired(l => l.Usuario)
                .WithMany()
                .HasForeignKey(l => l.UsuarioId);
                
        }
    }
}
