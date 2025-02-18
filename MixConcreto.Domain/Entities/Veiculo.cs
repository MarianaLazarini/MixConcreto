using MixConcreto.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MixConcreto.Domain.Entities
{
    public class Veiculo : BaseEntity<int>
    {
        public Veiculo() { }
        public Veiculo(int id, string placa, string modelo, int ano, float capacidade, string situacao)
        {
            Id = id;
            Placa = placa;
            Modelo = modelo;
            Ano = ano;
            Capacidade = capacidade;
            Situacao = situacao;
        }

        public string Placa { get; set; }
        public string Modelo { get; set; }
        public string Situacao { get; set; }
        public int Ano { get; set; }
        public float Capacidade { get; set; }
    }
}
