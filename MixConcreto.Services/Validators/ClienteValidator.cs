using FluentValidation;
using MixConcreto.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MixConcreto.Services.Validators
{
    public class ClienteValidator : AbstractValidator<Cliente>
    {
        public ClienteValidator()
        {
            RuleFor(i => i.Nome)
                .NotEmpty().WithMessage("Por Favor informe o Nome.")
                .NotNull().WithMessage("Por Favor informe o Nome.");

            RuleFor(i => i.Endereco)
                .NotEmpty().WithMessage("Por Favor informe o Endereço.")
                .NotNull().WithMessage("Por Favor informe o Endereço.");

            RuleFor(i => i.Bairro)
                .NotEmpty().WithMessage("Por Favor informe o Bairro.")
                .NotNull().WithMessage("Por Favor informe o Bairro.");

            RuleFor(i => i.Cidade)
                .NotEmpty().WithMessage("Por Favor informe o Cidade.")
                .NotNull().WithMessage("Por Favor informe o Cidade.");

            RuleFor(i => i.Cpf)
                .NotEmpty().WithMessage("Por Favor informe o CPF.")
                .NotNull().WithMessage("Por Favor informe o CPF.");

            RuleFor(i => i.Email)
                .NotEmpty().WithMessage("Por Favor informe o Email.")
                .NotNull().WithMessage("Por Favor informe o Email.");

            RuleFor(i => i.Telefone)
                .NotEmpty().WithMessage("Por Favor informe o Telefone.")
                .NotNull().WithMessage("Por Favor informe o Telefone.");
        }
    }
}
