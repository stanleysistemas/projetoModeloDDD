

using ProjetoModeloDDD.Application.Interface;
using ProjetoModeloDDD.Domain.Entities;
using ProjetoModeloDDD.Domain.Interfaces.Services;

namespace ProjetoModeloDDD.Application
{
    public class AppServiceUsuario : AppServiceBase<Usuario>, IAppServiceUsuario
    {
        private readonly IServiceUsuario _serviceUsuario;

        public AppServiceUsuario(IServiceUsuario serviceUsuario)
            : base(serviceUsuario)
        {
            _serviceUsuario = serviceUsuario;
        }
    }
}
