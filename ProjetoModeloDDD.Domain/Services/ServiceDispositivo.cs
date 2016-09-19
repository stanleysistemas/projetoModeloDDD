using ProjetoModeloDDD.Domain.Entities;
using ProjetoModeloDDD.Domain.Interfaces.Services;
using ProjetoModeloDDD.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoModeloDDD.Domain.Services
{
    public class ServiceDispositivo : ServiceBase<Dispositivo>, IServiceDispositivo
    {
        private readonly IRepositoryDispositivo _repositoryDispositivo;

        public ServiceDispositivo(IRepositoryDispositivo repositoryDispositivo)
            :base(repositoryDispositivo)
        {
            _repositoryDispositivo = repositoryDispositivo;
        }

        public IEnumerable<Dispositivo> BuscaPorUsuario(int id)
        {
            return _repositoryDispositivo.BuscaPorUsuario(id);
        }

        public IEnumerable<Dispositivo> BuscarPorImei(string imei)
        {
            return _repositoryDispositivo.BuscarPorImei(imei);
        }
    }
}
