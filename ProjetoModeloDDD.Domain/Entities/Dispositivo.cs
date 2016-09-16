using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoModeloDDD.Domain.Entities
{
    public class Dispositivo
    {
        public int DispositivoId { get; set; }
        public string IMEI { get; set; }
        public string NomeDispositivo { get; set; }
        public DateTime DataCadastro { get; set; }
        public string Ativo { get; set; }

        public int UsuarioId { get; set; }

        public virtual Usuario Usuario{ get; set; }
    }
}
