using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoModeloDDD.Domain.Interfaces;
using ProjetoModeloDDD.Domain.Entities;

namespace ProjetoModeloDDD.Infra.Data.Repositories
{
    public class RepositoryLocalizacaoUsuario : RepositoryBase<LocalizacaoUsuario>, IRepositoryLocalizacaoUsuario
    {
        public IEnumerable<LocalizacaoUsuario> BuscaUsuario(int id)
        {
            return Db.LocalizacaoUsuarios.Where(d => d.UsuarioId == id);
        }
    }
}
