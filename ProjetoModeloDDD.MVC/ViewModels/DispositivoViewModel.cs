using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetoModeloDDD.MVC.ViewModels
{
    public class DispositivoViewModel
    {
        [Key]
        public int DispositivoId { get; set; }

        [Required(ErrorMessage = "Preencha o campo Nome Dispositivo")]
        [MaxLength(150, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(10, ErrorMessage = "Mínimo {0} caracteres")]
        public string NomeDispositivo { get; set; }

        [DisplayName("Ativo ?")]
        public bool Ativo { get; set; }

        public int UsuarioId { get; set; }

        public virtual UsuarioViewModel Usuario { get; set; }
    }
}