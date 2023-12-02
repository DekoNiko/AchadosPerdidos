using AchadosPerdidos.Winform.Model;
using AchadosPerdidos.Winform.Util;
using AchadosPerdidos.Winform.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AchadosPerdidos.Winform
{
	public partial class fHome : Form
	{
		public fHome()
		{
			InitializeComponent();
			menuStrip1.Enabled = true;
			TelaLogin();
			this.ControlBox = false;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
		}

		public void TelaLogin()
		{
			#region Paleta de cores
			var corPrincipal = Color.DarkSlateBlue;
			var corBranca = Color.White;
			#endregion

			pnlHome.Controls.Clear();
			var telaLogin = new LoginUserView();
			telaLogin.Top = (pnlHome.Height / 2) - (telaLogin.Height - 35);
			telaLogin.Left = (pnlHome.Width / 2) - (telaLogin.Width - 80);
			pnlHome.Controls.Add(telaLogin);
			pnlHome.BackColor = Color.DimGray;

			#region CorMenu
			lblLogotipo.BackColor = corPrincipal;
			lblLogotipo.ForeColor = corBranca;
			menuStrip1.BackColor = corPrincipal;
			achadosEPerdidosToolStripMenuItem.ForeColor = corBranca;
			menuToolStripMenuItem.ForeColor = corBranca;
			#endregion
		}

		private void logarToolStripMenuItem_Click(object sender, EventArgs e)
		{
			TelaLogin();
		}

		private void sairToolStripMenuItem_Click(object sender, EventArgs e)
		{
			UsuarioSecao.DeslogarUsuario();
			System.Windows.Forms.Application.Exit();
		}

		private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
		{
			pnlHome.Controls.Clear();
			if (!UsuarioSecao.SecaoAtiva())
				TelaLogin();
			else
				pnlHome.Controls.Add(new AddLostView());
		}

		public List<object> MenuModules()
		{
			novoToolStripMenuItem.Visible = false;
			cadastrarToolStripMenuItem.Visible = false;
			estoqueToolStripMenuItem.Visible = false;
			return MenuModules();
		}

		private void novoToolStripMenuItem_Click(object sender, EventArgs e)
		{//CRIAR USUARIO
			pnlHome.Controls.Clear();
		}

	}
}
