using AchadosPerdidos.Winform.Business;
using AchadosPerdidos.Winform.Data;
using AchadosPerdidos.Winform.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
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
        private LocalizacaoRepository _localizacaoRepository = new LocalizacaoRepository();
        private ProdutoRepository _produtoRepository = new ProdutoRepository();


        public AddLostView()
        {
            InitializeComponent();
            PopulateDropDowns();
        }

        private void PopulateDropDowns()
        {
            DropdownConvertUtil.PopulateDropdown(cbxCor, _corBusiness.ListCor(), "Id", "Descricao");
            DropdownConvertUtil.PopulateDropdown(cbxLocal, _localizacaoRepository.ListLocalizacao(), "Id", "Descricao");
            DropdownConvertUtil.PopulateDropdown(cbxMaterial, _produtoRepository.ListMaterial(), "Id", "Descricao");
        }

        public void PainelShow()
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

        private bool PreenchimentoCadastro()
        {
            if (cbxCor.SelectedIndex == -1 || cbxLocal.SelectedIndex == -1 || cbxMaterial.SelectedIndex == -1)
            {
                MessageBox.Show("Falta selecionar");
                return true;
            }
            else if (txbProduto.Text == "" || txbEntregador.Text == "")
            {
                MessageBox.Show("Falta preencher");
                return true;
            }
            else
            return false;
        }

        private void ValidacaoCadastro()
        {
            var infosConcat = $"{txbProduto.Text},{cbxCor.Text},{cbxMaterial.Text},{cbxLocal.Text}" +
                $",{txbEntregador.Text},{txbObs.Text}";
        }

        private void ckbNovoitem_CheckedChanged(object sender, EventArgs e)
        {
            PainelShow();
        }

        private void txbProduto_TextChanged(object sender, EventArgs e)
        {
            PainelShow();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            var preenche = PreenchimentoCadastro();
            if (preenche == false)
            {
                ValidacaoCadastro();
            }
        }
    }
}
