using FluentValidation;
using MixConcreto.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MixConcreto.Services.Validators
{
    public class VeiculoValidator : AbstractValidator<Veiculo>
    {
        public VeiculoValidator() 
        {
            RuleFor(i => i.Placa)
               .NotEmpty().WithMessage("Por Favor informe o Placa.")
               .NotNull().WithMessage("Por Favor informe o Placa.");

            RuleFor(i => i.Modelo)
                .NotEmpty().WithMessage("Por Favor informe o Modelo.")
                .NotNull().WithMessage("Por Favor informe o Modelo.");

            RuleFor(i => i.Ano)
                .NotEmpty().WithMessage("Por Favor informe o Ano.")
                .NotNull().WithMessage("Por Favor informe o Ano.");

            RuleFor(i => i.Capacidade)
                .NotEmpty().WithMessage("Por Favor informe o Capacidade.")
                .NotNull().WithMessage("Por Favor informe o Capacidade.");

            RuleFor(i => i.Situacao)
                .NotEmpty().WithMessage("Por Favor informe o Situacao.")
                .NotNull().WithMessage("Por Favor informe o Situacao.");
        }
    }
}
