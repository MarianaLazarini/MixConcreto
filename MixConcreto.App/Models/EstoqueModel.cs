using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MixConcreto.App.Models
{
    public class EstoqueModel
    {
        public string Nome { get; set; }
        public float QuantidadeAtual { get; set; }
        public string Unidade { get; set; }
        public float PrecoUnitario { get; set; }
        public string Fornecedor { get; set; }
    }
}
