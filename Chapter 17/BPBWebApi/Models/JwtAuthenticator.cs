using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace BPBWebApi.Models
{
	public class JwtAuthenticator : IJwtAuthenticator
	{
		Dictionary<string, string> UserRepository = new Dictionary<string, string>
		{
			{ "firstUser","test1"},
			{ "secondUser","test2"},
			{ "thirdUser","test3"},
		};

		private readonly IConfiguration _configuration;
		public JwtAuthenticator(IConfiguration configuration)
		{
			this._configuration = configuration;
		}
		public Token Authenticate(User user)
		{

			if (!UserRepository.Any(x => x.Key == user.Login && x.Value == user.Password))
			{
				throw new UnauthorizedAccessException("Invalid login and/or password");
			}

		
			var tokenHandler = new JwtSecurityTokenHandler();
			var tokenKey = Encoding.UTF8.GetBytes(_configuration["JWT:Key"]);
			var tokenDescriptor = new SecurityTokenDescriptor
			{
				Subject = new ClaimsIdentity(new Claim[]
			  {
			 new Claim(ClaimTypes.Name, user.Login)
			  }),
				Expires = DateTime.UtcNow.AddMinutes(10),
				SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(tokenKey), 
				SecurityAlgorithms.HmacSha256Signature)
			};

			var token = tokenHandler.CreateToken(tokenDescriptor);
			return new Token { JwtToken = tokenHandler.WriteToken(token) };

		}
	}
}


