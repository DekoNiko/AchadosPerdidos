using AchadosPerdidos.Winform.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.WindowsRuntime;
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

        public bool IsValidLogin()
        {
            bool isValid = false;

            var hashPass = HashPassword();

            return isValid;
        }

        public void Verificar(UsuarioModel model)
        {
            var userBus = new LoginUserBusiness();
            
            if (IsValidLogin() == true)
            {
                userBus.ValidarLogin(model);
            }
        }

        private string HashPassword()
        {
            return this.Password;
        }
    }
}
