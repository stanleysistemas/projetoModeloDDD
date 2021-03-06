﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoModeloDDD.Domain.Entities
{
    public class LocalizacaoUsuario
    {
        public int LocalizacaoId { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public float Precisao { get; set; }
        public DateTime DtGps { get; set; }
        public string Provider { get; set; }
        public int UsuarioId { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}
