using senai_roman_webAPI.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_roman_webAPI.Interfaces
{
    public class IUsuarioRepository
    {
        /// <summary>
        /// Verifica a identificação do usuário
        /// </summary>
        /// <param name="email">Email</param>
        /// <param name="senha">Senha</param>
        /// <returns>Objeto de usuário logado</returns>
        Usuario Logar(string email, string senha);
    }
}
