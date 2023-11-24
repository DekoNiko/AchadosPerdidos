using AchadosPerdidos.Winform.Data;
using AchadosPerdidos.Winform.Model;
using AchadosPerdidos.Winform.View;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace AchadosPerdidos.Winform.Business
{
    public class CorBusiness
    {
        private CorRepository _corRepository = new CorRepository();
        public List<CorModel> ListCor()
        {
            return _corRepository.ListCor();
        }
        public void InsertCor(CorModel model)
        {
            var listCor = _corRepository.ListCor();

            if (listCor.Any(cor => cor.Descricao.Trim().ToUpper() == model.Descricao.Trim().ToUpper()))
            {
                throw new Exception("Cor Existente");
            }

            _corRepository.InsertCor(model);
        }
    }
}
