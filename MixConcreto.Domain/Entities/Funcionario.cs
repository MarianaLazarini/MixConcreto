using MixConcreto.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MixConcreto.Domain.Entities
{
    public class Funcionario : BaseEntity<int>
    {
        public Funcionario() 
        {
        }

        public Funcionario(int id, string nome, string cpf, string telefone, string endereco, string bairro, string cidade, string cargo, float salario, bool status, DateTime dataAdmissao)
        {
            Id = id;
            Nome = nome;
            Cpf = cpf;
            Telefone = telefone;
            Endereco = endereco;
            Bairro = bairro;
            Cidade = cidade;
            Cargo = cargo;
            Salario = salario;
            Status = status;
            DataAdmissao = dataAdmissao;
        }

        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Telefone { get; set; }
        public string Cargo { get; set; }
        public string Endereco { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public float Salario { get; set; }
        public bool Status { get; set; }
        public DateTime DataAdmissao { get; set; }
    }
}
