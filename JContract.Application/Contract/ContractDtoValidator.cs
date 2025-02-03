using FluentValidation;
using JContract.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JContract.Application.Contract
{
    public class ContractDtoValidator : AbstractValidator<ContractDto>
    {
        public ContractDtoValidator(IContractRepository repository)
        {
            RuleFor(c => c.FullName)
                .NotEmpty()
                .MinimumLength(2).WithMessage("Name should have atleast 2 characters")
                .MaximumLength(30);

            RuleFor(c => c.NrUmowy)
                .NotEmpty();
                

            RuleFor(c => c.PhoneNumber)
                
                .MinimumLength(8)
                .MaximumLength(12);
        }
    }
}
