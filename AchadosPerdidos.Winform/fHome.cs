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
		private ModulosMenuModel _modulosMenuModel;
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

        #region ModulosMenuStrip
		/*
		public ToolStripItemCollection MenuStripColecao
		{
			get { return menuStrip1.Items; }
			set
			{
				menuStrip1.Items.Clear();
				foreach (var elem in value)
				{ menuStrip1.Items.Add((ToolStripItem)elem); }
			}
		}

		public void AtribuirModulos(ModulosMenuModel model)
		{
			List<MenuStrip> allitems = new List<MenuStrip>();
			foreach (MenuStrip menu in menuStrip1.Items)
			{ allitems.Add(menu);
				//allitems.AddRange(GetItems(menu));
			}

		}
		*/
        #endregion

    }
}
