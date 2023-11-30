using AchadosPerdidos.Winform.Business;
using AchadosPerdidos.Winform.Data.Context;
using AchadosPerdidos.Winform.Model;
using AchadosPerdidos.Winform.Util;
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
		private UsuarioBusiness _usuarioBusiness = new UsuarioBusiness();

		public LoginUserView()
		{
			InitializeComponent();
			Layout();
			txbLoginUser.Text = "nicodemos";
			txbSenhaUser.Text = "1234";
		}

		public  void Layout()
		{
			BackColor = Color.CadetBlue;
			BorderStyle = BorderStyle.FixedSingle;
		}

		private void btnEntrarLogin_Click(object sender, EventArgs e)
		{
			try
			{
				var usuario = _usuarioBusiness.ValidarLogin(txbLoginUser.Text, txbSenhaUser.Text);
				UsuarioSecao.LogarUsuario(usuario);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Ops!",
					MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		private void btnSairLogin_Click(object sender, EventArgs e)
		{
			System.Windows.Forms.Application.Exit();
		}
	}
}
