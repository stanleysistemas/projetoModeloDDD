using System;
using System.Collections.Generic;
using ProjetoModeloDDD.Domain.Entities;
using ProjetoModeloDDD.Domain.Interfaces;
using System.Linq;

namespace ProjetoModeloDDD.Infra.Data.Repositories
{
    public class RepositoryDispositivo : RepositoryBase<Dispositivo>, IRepositoryDispositivo
    {
        public IEnumerable<Dispositivo> BuscaPorUsuario(int Id)
        {
            return Db.Dispositivos.Where(d => d.UsuarioId == Id);
        }

        public IEnumerable<Dispositivo> BuscarPorImei(string Imei)
        {
            return Db.Dispositivos.Where(d => d.IMEI == Imei);
        }
    }
}
