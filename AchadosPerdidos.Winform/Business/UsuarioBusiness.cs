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
			var model = MappingUserModel(login, password);
			model.IsValidLogin();
			model.HashPassword();
			model = _usuarioRepository.GetUsuarioByLoginPassword(model.Login, model.Password);

			model.SignInValid();

			return model;
		}

		#region Mappings
		private UsuarioModel MappingUserModel(string login, string password)
		{
			return new UsuarioModel() { Login = login, Password = password };
		}
		#endregion
	}
}
