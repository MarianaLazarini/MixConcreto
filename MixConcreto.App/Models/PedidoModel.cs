using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MixConcreto.App.Models
{
    public class PedidoModel
    {
        public DateTime DataPedido { get; set; }
        public string Situacao { get; set; }
        public float ValorTotal { get; set; }
        public float Quantidade { get; set; }
        public int IdCliente { get; set; }
        public string Cliente { get; set; }
    }
}
