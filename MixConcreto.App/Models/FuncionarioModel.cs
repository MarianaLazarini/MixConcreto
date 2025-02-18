using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MixConcreto.App.Models
{
    public class FuncionarioModel
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Telefone { get; set; }
        public string Cargo { get; set; }
        public string Endereco { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public float Salario { get; set; }
        public DateTime DataAdmissao { get; set; }
        public bool Status { get; set; }
    }
}
