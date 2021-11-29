using System;
using System.Collections.Generic;

#nullable disable

namespace senai_roman_webAPI.Domains
{
    public partial class Usuario
    {
        public short IdUsuario { get; set; }
        public short? IdTipoUsuario { get; set; }
        public string NomeUsuario { get; set; }
        public string EmailUsuario { get; set; }
        public string SenhaUsuario { get; set; }

        public virtual Tipousuario IdTipoUsuarioNavigation { get; set; }
    }
}
