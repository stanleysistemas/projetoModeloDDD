using ProjetoModeloDDD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoModeloDDD.Domain.Interfaces.Services
{
    public interface IServiceDispositivo : IServiceBase<Dispositivo> 
    {
        IEnumerable<Dispositivo> BuscaPorUsuario(int id);

        IEnumerable<Dispositivo> BuscarPorImei(string imei);
    }
}
