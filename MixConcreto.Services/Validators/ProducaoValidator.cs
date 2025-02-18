using FluentValidation;
using MixConcreto.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MixConcreto.Services.Validators
{
    public class ProducaoValidator : AbstractValidator<Producao>
    {
        public ProducaoValidator() 
        {
            RuleFor(i => i.Situacao)
                .NotEmpty().WithMessage("Por Favor informe a Situação.")
                .NotNull().WithMessage("Por Favor informe a Situação.");

            RuleFor(i => i.DataProducao)
                .NotEmpty().WithMessage("Por Favor informe a Data de Produção.")
                .NotNull().WithMessage("Por Favor informe a Data de Produção.");
        }
    }
}
