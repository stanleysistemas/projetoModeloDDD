using ProjetoModeloDDD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoModeloDDD.Domain.Interfaces
{
    public interface IRepositoryDispositivo : IRepositoryBase<Dispositivo>
    {
        IEnumerable<Dispositivo> BuscarPorImei(string Imei);
        IEnumerable<Dispositivo> BuscaPorUsuario(int Id);
    }
}
