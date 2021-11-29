using senai_roman_webAPI.Contexts;
using senai_roman_webAPI.Domains;
using senai_roman_webAPI.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_roman_webAPI.Repositories
{
    public class ProjetoRepository : IProjetoRepository
    {
        RomanContext ctx = new RomanContext();

        public void Cadastrar(Projeto objCadastrado)
        {
            ctx.Projetos.Add(objCadastrado);
            ctx.SaveChanges();
        }

        public List<Projeto> Listar()
        {
            return ctx.Projetos.ToList();
        }
    }
}
