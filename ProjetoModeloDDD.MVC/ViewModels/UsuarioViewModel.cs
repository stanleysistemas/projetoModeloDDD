using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using ProjetoModeloDDD.Domain.Entities;

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

        [Required(ErrorMessage = "Preencha o campo E-mail")]
        [MaxLength(150, ErrorMessage = "Máximo {0} caracteres")]
        [EmailAddress(ErrorMessage = "Preencha um E-mail válido")]
        [DisplayName("E-mail")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Preencha o campo Senha")]
        [MaxLength(100, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(10, ErrorMessage = "Mínimo {0} caracteres")]
        public string Senha { get; set; }

        [ScaffoldColumn(false)]
        public string SenhaKey { get; set; }

        [ScaffoldColumn(false)]
        public DateTime DataCadastro { get; set; }

        [ScaffoldColumn(false)]
        public string Sexo { get; set; }

        [ScaffoldColumn(false)]
        public byte Foto { get; set; }
        [ScaffoldColumn(false)]
        public int DatadeNascimento { get; set; }
        [ScaffoldColumn(false)]
        public int Idade { get; set; }
        [ScaffoldColumn(false)]
        public bool Ativo { get; set; }

        public virtual IEnumerable<DispositivoViewModel> Dispositivos { get; set; }

       // public virtual IEnumerable<LocalizacaoUsuarioViewModel> LocalizacaoUsuarios { get; set; }
    }
}