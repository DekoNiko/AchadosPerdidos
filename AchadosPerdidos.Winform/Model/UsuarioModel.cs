using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AchadosPerdidos.Winform.Model
{
    public class UsuarioModel
    {
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

        private string HashPassword()
        {
            return this.Password;
        }
    }
}
