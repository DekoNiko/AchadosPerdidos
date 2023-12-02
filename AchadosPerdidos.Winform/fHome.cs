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
		}

		public void TelaLogin()
		{
			pnlHome.Controls.Clear();
			var telaLogin = new LoginUserView();
			telaLogin.Top = (pnlHome.Height / 2) - (telaLogin.Height - 35);
			telaLogin.Left = (pnlHome.Width / 2) - (telaLogin.Width - 80);
			pnlHome.Controls.Add(telaLogin);
			pnlHome.BackColor = Color.DimGray;

			#region CorMenu
			menuStrip1.BackColor = Color.DimGray;
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

	}
}
