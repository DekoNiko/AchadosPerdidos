using AchadosPerdidos.Winform.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AchadosPerdidos.Winform.Data
{
    public class ProdutoRepository
    {
        public ProdutoRepository()
        {
        }
        public List<ProdutoModel> ListMaterial()
        {
            return listMaterialMock();

        }
        public List<ProdutoModel> ListProduto()
        {
            return listProdutoMock();
        }

        public ProdutoModel GetProduto(int Id)
        {
            return new ProdutoModel();
        }

        public void InsertProduto(ProdutoModel model)
        {

        }

        #region Mock

        private List<ProdutoModel> listProdutoMock()
        {
            var listProdutoMock = new List<ProdutoModel>();
            listProdutoMock.Add(new ProdutoModel() { Id = 1, IdCor = 1, Nome = "Garrafa" });
            listProdutoMock.Add(new ProdutoModel() { Id = 2, IdCor = 2, Nome = "Telefone" });
            listProdutoMock.Add(new ProdutoModel() { Id = 3, IdCor = 3, Nome = "Fone de Ouvido" });
            listProdutoMock.Add(new ProdutoModel() { Id = 4, IdCor = 4, Nome = "Carregador" });
            return listProdutoMock;
        }

        private List<ProdutoModel> listMaterialMock()
        {
            var listMaterialMock = new List<ProdutoModel>();
            listMaterialMock.Add(new ProdutoModel() { Id = 1, Descricao = "Metal" });
            listMaterialMock.Add(new ProdutoModel() { Id = 2, Descricao = "Aluminio" });
            listMaterialMock.Add(new ProdutoModel() { Id = 3, Descricao = "Plastico" });
            return listMaterialMock;
        }

        #endregion
    }
}
