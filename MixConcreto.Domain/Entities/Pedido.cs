using MixConcreto.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MixConcreto.Domain.Entities
{
    public class Pedido : BaseEntity<int>
    {
        public Pedido() { }

        public Pedido(int pedido, DateTime dataPedido, string situacao, float valorTotal, float quantidade, Cliente? cliente)
        {
            Id = Id;
            DataPedido = dataPedido;
            Situacao = situacao;
            ValorTotal = valorTotal;
            Cliente = cliente;
            Quantidade = quantidade;
        }

        public DateTime DataPedido { get; set; }
        public string Situacao { get; set; }
        public float ValorTotal { get; set; }
        public float Quantidade { get; set; }
        public Cliente? Cliente { get; set; }
    }
}
