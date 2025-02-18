using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MixConcreto.App.Models
{
    public class ProducaoModel
    {
        public DateTime DataProducao { get; set; }
        public string Situacao { get; set; }
        public int IdFuncionario { get; set; }
        public string Funcionario { get; set; }
        public int IdVeiculo { get; set; }
        public string Veiculo { get; set; }
        public int IdPedido { get; set; }
        public string Pedido { get; set; }
    }
}
