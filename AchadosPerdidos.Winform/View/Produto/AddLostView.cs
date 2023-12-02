using AchadosPerdidos.Winform.Business;
using AchadosPerdidos.Winform.Model;
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
		private SetorBusiness _setorBusiness = new SetorBusiness();
		private ProdutoBusiness _produtoBusiness = new ProdutoBusiness();

		public AddLostView()
		{
			InitializeComponent();
			Layout();
			if (!UsuarioSecao.SecaoAtiva())
			{
				this.Hide();
			}
			PopulateDropDowns();
			PopulateForm();

		}

		public void Layout()
		{
			this.BackColor = Color.GhostWhite;
		}

		private void PopulateDropDowns()
		{
			DropdownConvertUtil.PopulateDropdown(cbxCor, _corBusiness.ListCor(), "Id", "Descricao");
			DropdownConvertUtil.PopulateDropdown(cbxSetor, _setorBusiness.ListarSetor(), "Id", "Descricao");
			DropdownConvertUtil.PopulateDropdown(cbxMaterial, _produtoBusiness.ListarProduto(), "Id", "Material");
		}
		private void PopulateForm()
		{
			txbUsuario.Text = UsuarioSecao.GetUsername();
			txbUsuario.ReadOnly = true;
		}

		public void ClassTelas()
		{
			pnlImagem.Controls.Clear();
			var imagemPerdido = new ImagemPerdidoView();
			if (ckbListaCadastro.Checked)
			{
				imagemPerdido.Enabled = false;
				pnlImagem.Controls.Add(new ConsultarItensView());
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
