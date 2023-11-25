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

		public void IrUser(UsuarioModel model)
		{

		}

		private void btnEntrarLogin_Click(object sender, EventArgs e)
		{
			var user = new UsuarioModel() { Login = txbLoginUser.Text, Password = txbSenhaUser.Text };
			
			try
			{
				user.IsValidLogin();
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message, "Ops!",
					MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}
	}
}
