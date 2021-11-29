using System;
using System.Collections.Generic;

#nullable disable

namespace senai_roman_webAPI.Domains
{
    public partial class Projeto
    {
        public short IdProjeto { get; set; }
        public short? IdTema { get; set; }
        public string NomeProjeto { get; set; }
        public string DescricaoProjeto { get; set; }

        public virtual Tema IdTemaNavigation { get; set; }
    }
}
