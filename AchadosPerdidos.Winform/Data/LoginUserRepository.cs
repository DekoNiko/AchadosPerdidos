using AchadosPerdidos.Winform.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AchadosPerdidos.Winform.Data.Context
{
    public class LoginUserRepository
    {
        public LoginUserRepository()
        {

        }

        public List<UsuarioModel> ListUsers()
        {
            return UsersModelMock();
        }

        public UsuarioModel GetUsuario(int id, string login, string password)
        {
            return new UsuarioModel();
        }

        public void InsertUser(UsuarioModel model)
        {

        }

        #region UserMock

        private List<UsuarioModel> UsersModelMock()
        {
            var usersMock = new List<UsuarioModel>();
            usersMock.Add(new UsuarioModel() { Id = 1, Login = "fKadm", Password = "test123", Nome = "Deko Master"});
            usersMock.Add(new UsuarioModel() { Id = 2, Login = "fabi", Password = "Test123", Nome = "Fabiana Donegat"});
            usersMock.Add(new UsuarioModel() { Id = 3, Login = "walter", Password = "Test123", Nome = "Walter Pessanha"});
            return usersMock;
        }

        #endregion
    }
}
