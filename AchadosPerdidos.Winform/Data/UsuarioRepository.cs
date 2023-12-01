﻿using AchadosPerdidos.Winform.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AchadosPerdidos.Winform.Data.Context
{
	public class UsuarioRepository
	{
		private AchadosPerdidosContext _context;

		public UsuarioRepository()
		{
			_context = new AchadosPerdidosContext();
		}

		public List<UsuarioModel> ListarUsuario()
		{
<<<<<<< HEAD
			return _context.Usuario.Select(s => new UsuarioModel { Id = s.IdUsuario, Login = s.Login, Username = s.Username, Password = s.Password }).ToList();
=======
			return _context.Usuario.Select(s => new UsuarioModel { Id = s.IdUsuario, Login = s.Login, Username = s.Username, Password = s.Password, IsAdmin = s.IsAdmin }).ToList();
>>>>>>> Atualizacao_no_trabalho
		}

		public UsuarioModel GetUsuario(int id)
		{
			return _context.Usuario.Where(w => w.IdUsuario == id)
<<<<<<< HEAD
				.Select(s => new UsuarioModel { Id = s.IdUsuario, Login = s.Login, Username = s.Username, Password = s.Password }).Single();
=======
				.Select(s => new UsuarioModel { Id = s.IdUsuario, Login = s.Login, Username = s.Username, Password = s.Password, IsAdmin = s.IsAdmin }).Single();
>>>>>>> Atualizacao_no_trabalho
		}

		public void InsertUsuario(UsuarioModel model)
		{

		}

		public UsuarioModel GetUsuarioByLoginPassword(string login, string password)
		{
			return _context.Usuario.Where(w => w.Login == login && w.Password == password)
<<<<<<< HEAD
				.Select(s => new UsuarioModel { Id = s.IdUsuario, Login = s.Login, Username = s.Username, Password = s.Password }).SingleOrDefault();
=======
				.Select(s => new UsuarioModel { Id = s.IdUsuario, Login = s.Login, Username = s.Username, Password = s.Password, IsAdmin = s.IsAdmin }).SingleOrDefault();
>>>>>>> Atualizacao_no_trabalho
		}


		#region UserMock

		private List<UsuarioModel> UsersModelMock()
		{
			var usersMock = new List<UsuarioModel>();
			usersMock.Add(new UsuarioModel() { Id = 1, Login = "fKadm", Password = "test123", Username = "Deko Master" });
			usersMock.Add(new UsuarioModel() { Id = 2, Login = "fabi", Password = "Test123", Username = "Fabiana Donegat" });
			usersMock.Add(new UsuarioModel() { Id = 3, Login = "walter", Password = "Test123", Username = "Walter Pessanha" });
			return usersMock;
		}

		#endregion
	}
}
