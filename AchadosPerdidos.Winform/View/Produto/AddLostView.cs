using AchadosPerdidos.Winform.Business;
using AchadosPerdidos.Winform.Util;
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
		private CorBusiness _corBusiness = new CorBusiness();

		public AddLostView()
		{
			InitializeComponent();
			PopulateDropDowns();
		}

		private void PopulateDropDowns()
		{
			DropdownConvertUtil.PopulateDropdown(cbxCor, _corBusiness.ListCor(), "Id", "Descricao");
			//DropdownConvertUtil.PopulateDropdown(cbxMaterial,  )
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
