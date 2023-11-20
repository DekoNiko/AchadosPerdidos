using AchadosPerdidos.Winform.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AchadosPerdidos.Winform.Data
{
	public class CorRepository
	{
		public CorRepository()
		{

		}

		public List<CorModel> ListCor()
		{
			return ListCorMock();
		}

		public CorModel GetCor(int id)
		{
			return new CorModel();
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
