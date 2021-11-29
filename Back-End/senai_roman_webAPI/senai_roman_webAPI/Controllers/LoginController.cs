using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using senai_roman_webAPI.Domains;
using senai_roman_webAPI.Interfaces;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace senai_roman_webAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private IUsuarioRepository _Repository { get; set; }

        public LoginController()
        {
            _Repository = new IUsuarioRepository();
        }

        /// <summary>
        /// Método responsável por fazer o login na api
        /// </summary>
        /// <returns>Lista apenas o objeto selecionado</returns>
        [HttpPost()]
        public IActionResult Login(LoginViewModel login)
        {
            try
            {
                Usuario usuarioBuscado = _Repository.Logar(login.email, login.senha);

                if(usuarioBuscado == null)
                {
                    return BadRequest($"E-mail ou senha inválidos!");
                }
                var minhasClaims = new[]
                {
                    new Claim(JwtRegisteredClaimNames.Email, usuarioBuscado.EmailUsuario),
                    new Claim(ClaimTypes.Role, usuarioBuscado.IdTipoUsuario.ToString()),
                    new Claim("role", usuarioBuscado.IdTipoUsuario.ToString())
                }
                var key = new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes("roman-chave-autenticacao"));
                var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

                var meuToken = new JwtSecurityToken(
                    issuer: "senai_roman.webAPI",
                    audience: "senai_roman.webAPI"
                    claims: minhasClaims,
                    expires: DateTime.Now.AddHours(2),
                    signingCredentials: creds
                    );

                return Ok(new
                {
                    token = new JwtSecurityTokenHandler().WriteToken(meuToken)
                });
            }
            catch(Exception ex)
            {
                return BadRequest(ex);
            }
        }
    }
}
