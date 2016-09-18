using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetoModeloDDD.MVC.ViewModels
{
    public class LocalizacaoUsuarioViewModel
    {
        [Key]
        public int LocalizacaoId { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public float Precisao { get; set; }
        public DateTime DtGps { get; set; }
        public string Provider { get; set; }
        public int UsuarioId { get; set; }
        public virtual UsuarioViewModel Usuario { get; set; }
    }
}