using AchadosPerdidos.Winform.Data;
using AchadosPerdidos.Winform.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AchadosPerdidos.Winform.Business
{
    public class LocalizacaoBusiness
    {
        private LocalizacaoRepository _localizacaoRepository = new LocalizacaoRepository();
        public List<LocalizacaoModel> ListLocalizacao()
        {
            return _localizacaoRepository.ListLocalizacao(); //TODO: ADICIONAR LISTA DE LOCALIZACAO;
        }
        public void InsertLocalizacao(LocalizacaoModel localizacao)
        {
            var listLocalizacao = _localizacaoRepository.ListLocalizacao();

            if (listLocalizacao.Any(local => local.Descricao.Trim().ToUpper() == localizacao.Descricao.Trim().ToUpper()))
            {
                throw new Exception("Local Existente");
            }

            _localizacaoRepository.InsertLocalizacao(localizacao);
        }
    }
}
