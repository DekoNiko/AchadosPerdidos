using AchadosPerdidos.Winform.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AchadosPerdidos.Winform.Business
{
    public class ProdutoBusiness
    {
        public List<ProdutoModel> ListarProduto()
        {
            return new List<ProdutoModel>(); //TODO: CRIAR DEVOLUCAO PARA LISTAR PRODUTO;
        }

        public int IncluirProduto(ProdutoModel produto)
        {
            //TODO: APLICAR REGRAS E SALVAR EM BANCO DE DADOS;
            return 0;
        }

        public void ExcluirProduto(int id)
        {
            //TODO: DESATIVAR O PRODUTO
        }
    }
}
