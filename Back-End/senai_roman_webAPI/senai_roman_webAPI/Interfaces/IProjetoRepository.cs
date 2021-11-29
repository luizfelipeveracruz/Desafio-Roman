using senai_roman_webAPI.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_roman_webAPI.Interfaces
{
    /// <summary>
    /// Interface responsável pelo ProjetoRepository
    /// </summary>
    interface IProjetoRepository
    {
        /// <summary>
        /// Lista todos os projetos
        /// </summary>
        /// <returns>Uma lista de projetos</returns>
        List<Projeto> Listar();

        /// <summary>
        /// Cadastra o objeto
        /// </summary>
        /// <param name="objCadastrado">Objeto cadastrado</param>
        void Cadastrar(Projeto objCadastrado);
    }
}
