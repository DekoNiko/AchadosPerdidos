using AchadosPerdidos.Winform.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AchadosPerdidos.Winform.Data
{
    public class LocalizacaoRepository
    {
        public LocalizacaoRepository()
        {

        }

        public List<LocalizacaoModel> ListLocalizacao()
        {
            return listLocalMock();
        }

        public LocalizacaoModel GetLocalizacao(int Id)
        {
            return new LocalizacaoModel();
        }

        public void InsertLocalizacao(LocalizacaoModel model)
        {

        }

        #region Mock

        private List<LocalizacaoModel> listLocalMock()
        {
            var listLocalMock = new List<LocalizacaoModel>();
            listLocalMock.Add(new LocalizacaoModel() { Id = 1, Descricao = "Secretaria Social" });
            listLocalMock.Add(new LocalizacaoModel() { Id = 2, Descricao = "Tenis" });
            listLocalMock.Add(new LocalizacaoModel() { Id = 3, Descricao = "Cobranca" });
            listLocalMock.Add(new LocalizacaoModel() { Id = 4, Descricao = "Contabilidade" });
            listLocalMock.Add(new LocalizacaoModel() { Id = 5, Descricao = "Academia" });
            return listLocalMock;

        }

        #endregion
    }
}
