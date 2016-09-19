

using ProjetoModeloDDD.Application.Interface;
using ProjetoModeloDDD.Domain.Entities;

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
