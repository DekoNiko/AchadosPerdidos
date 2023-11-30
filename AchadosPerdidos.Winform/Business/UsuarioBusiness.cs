using AchadosPerdidos.Winform.Data.Context;
using AchadosPerdidos.Winform.Model;
using AchadosPerdidos.Winform.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AchadosPerdidos.Winform.Business
{
	public class UsuarioBusiness
	{
		private UsuarioRepository _usuarioRepository = new UsuarioRepository();
		public UsuarioBusiness()
		{

		}

		public UsuarioModel ValidarLogin(string login, string password)
		{
			var model = new UsuarioModel() { Login = login, Password = password };
			model.IsValidLogin();
			model.HashPassword();
			var usuario = _usuarioRepository.GetUsuarioByLoginPassword(model.Login, model.Password);

			if (usuario is null || usuario.Id == 0)
				throw new Exception("Usuario invalido!");

			return usuario;
		}
	}
}
