using ProjetoModeloDDD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoModeloDDD.Application.Interface
{
    public interface IAppServiceDispositivo : IAppServiceBase<Dispositivo>
    {
        IEnumerable<Dispositivo> BuscaPorUsuario(int id);

        IEnumerable<Dispositivo> BuscarPorImei(string imei);
    }
}
