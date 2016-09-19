using System;
using System.Collections.Generic;
using ProjetoModeloDDD.Application.Interface;
using ProjetoModeloDDD.Domain.Entities;
using ProjetoModeloDDD.Domain.Interfaces.Services;

namespace ProjetoModeloDDD.Application
{
    public class AppServiceDispositivo : AppServiceBase<Dispositivo>, IAppServiceDispositivo
    {
        private readonly IServiceDispositivo _serviceDispositivo;

        public AppServiceDispositivo(IServiceDispositivo serviceDispositivo)
            : base(serviceDispositivo)
        {
            _serviceDispositivo = serviceDispositivo;
        }

        public IEnumerable<Dispositivo> BuscaPorUsuario(int id)
        {
            return _serviceDispositivo.BuscaPorUsuario(id);
        }

        public IEnumerable<Dispositivo> BuscarPorImei(string imei)
        {
            return _serviceDispositivo.BuscarPorImei(imei);
        }
    }
}