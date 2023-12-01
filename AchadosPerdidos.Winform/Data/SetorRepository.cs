using AchadosPerdidos.Winform.Business;
using AchadosPerdidos.Winform.Data.Context;
using AchadosPerdidos.Winform.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AchadosPerdidos.Winform.Data
{
	public class SetorRepository
	{
		private AchadosPerdidosContext _context;

		public SetorRepository()
		{
			_context = new AchadosPerdidosContext();
		}

		public List<SetorModel> ListaLocalizacao()
		{
			return _context.Setor.Select(s => new SetorModel { Id = s.IdSetor, Descricao = s.Descricao }).ToList();
		}
		 
		public SetorModel GetLocalizacao(int id)
		{
			return _context.Setor.Where(w => w.IdSetor == id).Select(s => new SetorModel { Id = s.IdSetor, Descricao = s.Descricao }).Single();
		}

		public void InsertLocalizacao(SetorModel model)
		{

		}

		#region Mock

		private List<SetorModel> listaLocalizacaoMock()
		{
			var listaLocal = new List<SetorModel>();
			listaLocal.Add(new SetorModel() { Id = 1, Descricao = "Tenis" });
			listaLocal.Add(new SetorModel() { Id = 2, Descricao = "Cobranca" });
			listaLocal.Add(new SetorModel() { Id = 3, Descricao = "Secretaria Social" });
			listaLocal.Add(new SetorModel() { Id = 4, Descricao = "Portaria" });
			return listaLocal;
		}

		#endregion
	}
}
