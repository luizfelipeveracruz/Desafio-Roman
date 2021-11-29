using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using senai_roman_webAPI.Domains;
using senai_roman_webAPI.Interfaces;
using senai_roman_webAPI.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_roman_webAPI.Contexts
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjetosController : ControllerBase
    {
        private IProjetoRepository _Repository { get; set; }

        public ProjetosController()
        {
            _Repository = new ProjetoRepository();
        }

        [HttpGet]
        [Authorize]
        public IActionResult Listar()
        {
            try
            {
                return Ok(_Repository.Listar());
            }
            catch(Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpPost]
        [Authorize]
        public IActionResult Cadastrar(Projeto obj)
        {
            _Repository.Cadastrar(obj);
            return StatusCode(201);
        }
    }
}
