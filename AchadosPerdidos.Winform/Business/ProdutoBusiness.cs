using AchadosPerdidos.Winform.Data;
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
        private ProdutoRepository _produtoRepository = new ProdutoRepository();

        public List<ProdutoModel> ListProduto()
        {
            return _produtoRepository.ListProduto(); //TODO: CRIAR DEVOLUCAO PARA LISTAR PRODUTO;
        }

        public void InsertMaterial(ProdutoModel produto)
        {
            var listMaterial = _produtoRepository.ListMaterial();
            //if (listMaterial.Any(product => product.Descricao.Trim().ToUpper() == produto.Descricao.Trim().ToUpper()))
            //IF DO PRODUTO: FALTA ALGUMA IDENTIFICACAO DO PRODUTO ESPECIFICO
            {
            //    throw new Exception("Produto Existente");
            }
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
