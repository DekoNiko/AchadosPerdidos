using AchadosPerdidos.Winform.Business;
using AchadosPerdidos.Winform.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AchadosPerdidos.Winform.View
{
    public partial class LoginUserView : UserControl
    {
        public LoginUserView()
        {
            InitializeComponent();
        }

        public bool ValidarLogin()
        {
            var appHome = new fHome();

            if (string.IsNullOrEmpty(txbLoginUser.Text.ToString()) || string.IsNullOrEmpty(txbSenhaUser.Text.ToString()))
            {
                MessageBox.Show("Login ou Senha Incorreto", "Ops!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

                using (appHome);

                return false;
            }
            else
            {
                //MessageBox.Show("Bem-vindo, \n" + txbLoginUser.Text);
                return true;
            }
            
        }
        public void IrUser(UsuarioModel model)
        {
            
        }

        private void btnEntrarLogin_Click(object sender, EventArgs e)
        {
            bool validLogin = ValidarLogin();
            var testValid = new UsuarioModel();

            if (validLogin == true)
            {
                return;
            }
        }
    }
}
