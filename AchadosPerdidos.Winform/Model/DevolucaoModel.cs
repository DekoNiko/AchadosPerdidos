using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AchadosPerdidos.Winform.Model
{
    public class DevolucaoModel
    {
        public int Id { get; set; }
        public int IdUsuario { get; set; }
        public int IdProduto { get; set; }
        public DateTime DataDevolucao { get; set; }
        public string Observacao { get; set; }
    }
}
