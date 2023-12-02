using AchadosPerdidos.Winform.Data.Context;
using AchadosPerdidos.Winform.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace AchadosPerdidos.Winform.Data
{
	public class CorRepository
	{
		private AchadosPerdidosContext _context;

		public CorRepository()
		{
			_context = new AchadosPerdidosContext();
		}

		public List<CorModel> ListCor()
		{
			return _context.Cor.Select(s => new CorModel { Id = s.IdCor, Descricao = s.Descricao }).ToList();
		}

		public CorModel GetCor(int id)
		{
			return _context.Cor.Where(w => w.IdCor == id).Select(s => new CorModel { Id = s.IdCor, Descricao = s.Descricao }).Single();
		}

		public void InsertCor(CorModel model)
		{

		}


		#region Mock

		private List<CorModel> ListCorMock()
		{
			var listCor = new List<CorModel>();
			listCor.Add(new CorModel() { Id = 1, Descricao = "Branco" });
			listCor.Add(new CorModel() { Id = 2, Descricao = "Preto" });
			listCor.Add(new CorModel() { Id = 3, Descricao = "Azul" });
			listCor.Add(new CorModel() { Id = 4, Descricao = "Rosa" });
			return listCor;
		}

		#endregion

	}
}
