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
			if (!UsuarioSecao.SecaoAtiva())
			{
				this.Width = 182;
				this.Height = 139;
				BackColor = Color.CadetBlue;
				BorderStyle = BorderStyle.FixedSingle;
				lblGetUsername.Hide();
				lblGetUsuario.Hide();
			}
			else
			{
				this.Width = 182;
				this.Height = 70;
				BackColor = Color.DarkOliveGreen;
				BorderStyle = BorderStyle.FixedSingle;
				txbLoginUser.Visible = false;
				txbSenhaUser.Visible = false;
				label1.Visible = false;
				label2.Visible = false;
				lblGetUsername.Show();
				lblGetUsuario.Show();
				lblGetUsername.Enabled = false;
				lblGetUsername.Text = UsuarioSecao.GetUsername();
			}
		}

		private void btnEntrarLogin_Click(object sender, EventArgs e)
		{
			try
			{
				var usuario = _usuarioBusiness.ValidarLogin(txbLoginUser.Text, txbSenhaUser.Text);
				UsuarioSecao.LogarUsuario(usuario);
				Layout();
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
