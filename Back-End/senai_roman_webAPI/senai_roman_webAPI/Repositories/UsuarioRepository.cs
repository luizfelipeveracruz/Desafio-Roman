using senai_roman_webAPI.Contexts;
using senai_roman_webAPI.Domains;
using senai_roman_webAPI.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_roman_webAPI.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        RomanContext ctx = new RomanContext();

        public Usuario Logar(string email, string senha)
        {
            Usuario user = ctx.Usuarios.FirstOrDefault(u => u.EmailUsuario == email);

            if (user != null && user.SenhaUsuario == senha)
            {
                return user;
            }

            return null;
        }
    }
}
