using AchadosPerdidos.Winform.Business;
using AchadosPerdidos.Winform.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AchadosPerdidos.Winform.Data
{
	public class LocaliacaoRepository
	{
		public LocaliacaoRepository()
		{
		}

		public List<LocalizacaoModel> ListaLocalizacao()
		{
			return listaLocalizacaoMock();
		}
		 
		public LocalizacaoModel GetLocalizacao(int id)
		{
			return new LocalizacaoModel();
		}

		public void InsertLocalizacao(LocalizacaoModel model)
		{

		}

		#region Mock

		private List<LocalizacaoModel> listaLocalizacaoMock()
		{
			var listaLocal = new List<LocalizacaoModel>();
			listaLocal.Add(new LocalizacaoModel() { Id = 1, Descricao = "Tenis" });
			listaLocal.Add(new LocalizacaoModel() { Id = 2, Descricao = "Cobranca" });
			listaLocal.Add(new LocalizacaoModel() { Id = 3, Descricao = "Secretaria Social" });
			listaLocal.Add(new LocalizacaoModel() { Id = 4, Descricao = "Portaria" });
			return listaLocal;
		}

		#endregion
	}
}
