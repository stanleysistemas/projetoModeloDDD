using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetoModeloDDD.MVC.ViewModels
{
    public class UsuarioViewModel
    {
        [Key]
        public int UsuarioId { get; set; }

        [Required(ErrorMessage = "Preencha o campo Nome")]
        [MaxLength(150, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo {0} caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Preencha o campo Nome")]
        [MaxLength(150, ErrorMessage = "Máximo {0} caracteres")]
        [EmailAddress(ErrorMessage = "Preencha um E-mail válido")]
        [DisplayName("E-mail")]
        public string Email { get; set; }

        public string Senha { get; set; }
        public string SenhaKey { get; set; }

        [ScaffoldColumn(false)]
        public DateTime DataCadastro { get; set; }

        public string Sexo { get; set; }
        public byte Foto { get; set; }
        public int DatadeNascimento { get; set; }
        public int Idade { get; set; }
        public bool Ativo { get; set; }

       // public virtual IEnumerable<Dispositivo> Dispositivos { get; set; }

       // public virtual IEnumerable<LocalizacaoUsuario> LocalizacaoUsuarios { get; set; }
    }
}