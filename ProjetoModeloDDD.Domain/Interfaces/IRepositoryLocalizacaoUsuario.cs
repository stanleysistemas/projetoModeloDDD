using ProjetoModeloDDD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoModeloDDD.Domain.Interfaces
{
    public interface IRepositoryLocalizacaoUsuario : IRepositoryBase<LocalizacaoUsuario>
    {
        IEnumerable<LocalizacaoUsuario> BuscaUsuario(int id);
    }
}
