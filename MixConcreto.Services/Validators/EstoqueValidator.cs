using FluentValidation;
using MixConcreto.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MixConcreto.Services.Validators
{
    public class EstoqueValidator : AbstractValidator<Estoque>
    {
        public EstoqueValidator() 
        {
            RuleFor(i => i.Nome)
                .NotEmpty().WithMessage("Por Favor informe o Nome.")
                .NotNull().WithMessage("Por Favor informe o Nome.");

            RuleFor(i => i.Unidade)
                .NotEmpty().WithMessage("Por Favor informe o Unidade.")
                .NotNull().WithMessage("Por Favor informe o Unidade.");

            RuleFor(i => i.Fornecedor)
                .NotEmpty().WithMessage("Por Favor informe o Fornecedor.")
                .NotNull().WithMessage("Por Favor informe o Fornecedor.");
        }
    }
}
