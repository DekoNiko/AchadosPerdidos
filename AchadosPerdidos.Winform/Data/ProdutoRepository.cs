using AchadosPerdidos.Winform.Data.Context;
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
        private AchadosPerdidosContext _context;
       
		public ProdutoRepository()
		{
			_context = new AchadosPerdidosContext();
		}

		public List<ProdutoModel> ListaProduto()
		{
			return _context.Produto.Select(s => new ProdutoModel { Id = s.Id.Produto, DataCriacao = s.DataCriacao, DataAtualizacao = s.DataAtualizacao }).ToList();
		}

		public ProdutoModel GetProduto(int id)
		{
			return _context.Produto.Where(w => w.IdProduto == id).Select(s => new ProdutoModel { Id = s.Id.Produto, DataCriacao = s.DataCriacao, DataAtualizacao = s.DataAtualizacao }).Single();
		}

		public void InsertProduto(ProdutoModel model)
		{

		}

		#region Mock

		private List<ProdutoModel> ListaMaterialMock()
		{
			var listMaterial = new List<ProdutoModel>();
			listMaterial.Add(new ProdutoModel { Id = 1, Descricao = "Vidro" });
			listMaterial.Add(new ProdutoModel { Id = 2, Descricao = "Plastico" });
			listMaterial.Add(new ProdutoModel { Id = 3, Descricao = "Ferro" });
			return listMaterial;
		}

		#endregion
	}
}
