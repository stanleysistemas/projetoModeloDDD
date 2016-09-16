﻿using ProjetoModeloDDDContext.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoModeloDDDContext.Infra.Data.EntityConfig
{
    public class DispositivoConfiguration : EntityTypeConfiguration<Dispositivo>
    {
        public DispositivoConfiguration()
        {
            HasKey(d => d.DispositivoId);

            Property(d => d.NomeDispositivo)
                .IsRequired()
                .HasMaxLength(100);

            Property(d => d.Ativo)
                .IsRequired()
                .HasMaxLength(1);

            HasRequired(u => u.Usuario)
                .WithMany()
                .HasForeignKey(u => u.UsuarioId);
    }
    }
}
