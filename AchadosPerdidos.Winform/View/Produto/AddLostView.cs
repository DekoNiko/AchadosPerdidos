using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AchadosPerdidos.Winform.View
{
	public partial class AddLostView : UserControl
	{
		public AddLostView()
		{
			InitializeComponent();

		}

		public void ClassTelas()
		{
			pnlImagem.Controls.Clear();
			var imagemPerdido = new ImagemPerdidoView();
			if (ckbNovoitem.Checked)
			{
				imagemPerdido.Enabled = false;
				pnlImagem.Controls.Add(new NovoItemView());
			}
			else if (!string.IsNullOrWhiteSpace(txbProduto.Text))
			{
				pnlImagem.Controls.Add(imagemPerdido);
			}
		}

		private void ckbNovoitem_CheckedChanged(object sender, EventArgs e)
		{
			ClassTelas();
		}

		private void txbProduto_TextChanged(object sender, EventArgs e)
		{
			ClassTelas();
		}
	}
}
