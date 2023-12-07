using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AchadosPerdidos.Winform.Model
{
    public class ProdutoModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string Observacao { get; set; }
        public int IdMaterial { get; set; }
        public int IdCor { get; set; }
        public int IdSetor { get; set; }
        public DateTime DataCriacao { get; set; }
        public DateTime DataAtualizacao { get; set; }
        public bool Devolvido { get; set; }
        public bool Excluido { get; set; }
    }
}
