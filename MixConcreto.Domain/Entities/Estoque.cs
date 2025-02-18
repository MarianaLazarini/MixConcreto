using MixConcreto.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MixConcreto.Domain.Entities
{
    public class Estoque : BaseEntity<int>
    {
        public Estoque() { }
        public Estoque(int id, string nome, float quantidadeAtual, string unidade, float precoUnitario, string fornecedor)
        {
            Id = id;
            Nome = nome;
            QuantidadeAtual = quantidadeAtual;
            Unidade = unidade;
            PrecoUnitario = precoUnitario;
            Fornecedor = fornecedor;
        }
        public string Nome { get; set; }
        public float QuantidadeAtual { get; set; }
        public string Unidade { get; set; }
        public float PrecoUnitario { get; set; }
        public string Fornecedor { get; set; }

    }
}
