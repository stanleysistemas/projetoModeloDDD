using System;
using System.Collections.Generic;
using ProjetoModeloDDD.Domain.Entities;
using ProjetoModeloDDD.Domain.Interfaces;
using System.Linq;

namespace ProjetoModeloDDD.Infra.Data.Repositories
{
    public class RepositoryDispositivo : RepositoryBase<Dispositivo>, IRepositoryDispositivo
    {
        public IEnumerable<Dispositivo> BuscaPorUsuario(int id)
        {
            return Db.Dispositivos.Where(d => d.UsuarioId == id);
        }

        public IEnumerable<Dispositivo> BuscarPorImei(string imei)
        {
            return Db.Dispositivos.Where(d => d.IMEI == imei);
        }
    }
}
