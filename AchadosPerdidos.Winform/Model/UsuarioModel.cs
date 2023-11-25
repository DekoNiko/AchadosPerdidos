using AchadosPerdidos.Winform.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace AchadosPerdidos.Winform.Model
{
	public class UsuarioModel
	{
		private LoginUserBusiness _loginUserBusiness = new LoginUserBusiness();

		public int Id { get; set; }
		public string Nome { get; set; }

		public string Login { get; set; }

		public string Password { get; set; }

		public void IsValidLogin()
		{
			if (string.IsNullOrWhiteSpace(this.Login) || string.IsNullOrWhiteSpace(this.Password))
				throw new Exception("Login ou Senha Incorreto");


			var hashPass = HashPassword();
		}

		private string HashPassword()
		{
			using (SHA256 sha256Hash = SHA256.Create())
			{
				// Converte a senha para um array de bytes
				byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(this.Password));

				// Converte o array de bytes para uma string hexadecimal
				StringBuilder builder = new StringBuilder();
				for (int i = 0; i < bytes.Length; i++)
				{
					builder.Append(bytes[i].ToString("x2"));
				}
				this.Password = builder.ToString();
			}
			return this.Password;
		}
	}
}
