using MixConcreto.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MixConcreto.Domain.Entities
{
    public class Producao : BaseEntity<int>
    {
        public Producao()
        {

        }

        public Producao(int id, DateTime dataProducao, string situacao, Pedido? pedido, Funcionario? funcionario, Veiculo? veiculo)
        {
            Id = id;
            DataProducao = dataProducao;
            Situacao = situacao;
            Pedido = pedido;
            Funcionario = funcionario;
            Veiculo = veiculo;

        }
        public DateTime DataProducao { get; set; }
        public string Situacao { get; set; }
        public Pedido? Pedido { get; set; }
        public Funcionario? Funcionario { get; set; }
        public Veiculo? Veiculo { get; set; }

    }
}
