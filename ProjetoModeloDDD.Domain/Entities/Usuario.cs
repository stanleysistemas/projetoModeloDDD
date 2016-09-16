using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoModeloDDD.Domain.Entities
{
    public class Usuario
    {

        public int UsuarioId { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string SenhaKey { get; set; }
        public DateTime DataCadastro { get; set; }
        public string Sexo { get; set; }
        public byte Foto { get; set; }
        public int DatadeNascimento { get; set; }
        public int Idade { get; set; }
        public bool Ativo { get; set; }

        public virtual IEnumerable<Dispositivo> Dispositivos { get; set; }

        

    }
}
