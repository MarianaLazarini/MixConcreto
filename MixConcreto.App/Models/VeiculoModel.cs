using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MixConcreto.App.Models
{
    public class VeiculoModel
    {
        public string Placa { get; set; }
        public string Modelo { get; set; }
        public string Situacao { get; set; }
        public int Ano { get; set; }
        public float Capacidade { get; set; }
    }
}
