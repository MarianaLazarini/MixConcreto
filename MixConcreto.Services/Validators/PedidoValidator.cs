using FluentValidation;
using MixConcreto.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MixConcreto.Services.Validators
{
    public class PedidoValidator : AbstractValidator<Pedido>
    {
        public PedidoValidator() 
        {
            RuleFor(i => i.DataPedido)
                .NotEmpty().WithMessage("Por Favor informe a data do pedido.")
                .NotNull().WithMessage("Por Favor informe a data do pedido.");

            RuleFor(i => i.Situacao)
                .NotEmpty().WithMessage("Por Favor informe a Situação.")
                .NotNull().WithMessage("Por Favor informe a Situação.");

            RuleFor(i => i.Quantidade)
                .NotEmpty().WithMessage("Por Favor informe a Quantidade.")
                .NotNull().WithMessage("Por Favor informe a Quantidade.");

            RuleFor(i => i.ValorTotal)
                .NotEmpty().WithMessage("Por Favor informe o Valor Total.")
                .NotNull().WithMessage("Por Favor informe o Valor Total.");
        }
    }
}
