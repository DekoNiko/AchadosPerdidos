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
    public class LoginUserBusiness
    {
        private LoginUserRepository _loginUserRepository = new LoginUserRepository();
        public LoginUserBusiness()
        {
        }

        public bool ValidarLogin(UsuarioModel model)
        {
            var validUser = _loginUserRepository.ListUsers();
            var logarUser = new UsuarioModel();
            var valid = logarUser.IsValidLogin();

            if (validUser.Any(user => user.Nome.Trim().ToUpper() == model.Nome.Trim().ToUpper()))
            {
                logarUser.IsValidLogin();
                return false;
            }
            else
                MessageBox.Show("User Invalid");
            return true;
        }
    }
}
