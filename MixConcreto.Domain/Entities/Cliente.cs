using MixConcreto.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MixConcreto.Domain.Entities
{
    public class Cliente : BaseEntity<int>
    {
        public Cliente() 
        {
        }
        public Cliente(int id, string nome, string cpf, string telefone, string email, string endereco, string bairro, string cidade)
        {
            Id = id;
            Nome = nome;
            Cpf = cpf;
            Telefone = telefone;
            Email = email;
            Endereco = endereco;
            Bairro = bairro;
            Cidade = cidade;
        }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public string Endereco { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }

    }
}
