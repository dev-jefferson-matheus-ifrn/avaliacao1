using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using gestaoEscolar;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;

namespace MyApp.Namespace
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] AuthDTO authDTO)
        {

            if(authDTO.senha != UsuarioADM.Senha || authDTO.usuario != UsuarioADM.Usuario)
            {
                return Unauthorized();
            }
            var claims = new[]
           {
                new Claim("usuario", UsuarioADM.Usuario)
            };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("MinhaChaveLongaSuperSecreta12345"));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(
                issuer: "GestaoEscolar",
                audience: "GestaoEscolar",
                claims: claims,
                expires: DateTime.Now.AddMinutes(30),
                signingCredentials: creds
            );

            var tokenString = new JwtSecurityTokenHandler().WriteToken(token);
            return Ok(new { Token = tokenString });
        }
    }

}
