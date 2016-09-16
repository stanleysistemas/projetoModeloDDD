using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectX.Domain.Entities
{
    public class PerfilUsuario
    {
        public int IdPerfilUsuario { get; set; }
        public string NomePerfil { get; set; }
        public DateTime DataCadastro { get; set; }
        public bool FlAdminMaster { get; set; }
        public bool FlAtivo { get; set; }
       // public virtual ICollection<Usuario> Usuarios { get; set; }
      //  public virtual ICollection<ModulosAcesso> ModulosAcesso { get; set; }
    }
}
