using AchadosPerdidos.Winform.Business;
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
		public SetorRepository()
		{
		}

		public List<SetorModel> ListaLocalizacao()
		{
			return listaLocalizacaoMock();
		}
		 
		public SetorModel GetLocalizacao(int id)
		{
			return new SetorModel();
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
