using DtoLayer.Dtos.AppUserDtos;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules.AppUserValidationRules
{
    public class AppUserRegisterValidator: AbstractValidator<AppUserRegisterDto>
    {
        public AppUserRegisterValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Name shouldn't be empty.");
            RuleFor(x => x.Surname).NotEmpty().WithMessage("Surname shouldn't be empty");
            RuleFor(x => x.Email).NotEmpty().WithMessage("Email shouldn't be empty");
            RuleFor(x => x.Password).NotEmpty().WithMessage("Password shouldn't be empty");
            RuleFor(x => x.ConfirmPassword).NotEmpty().WithMessage("Confirm Password shouldn't be empty");
            RuleFor(x => x.Name).MaximumLength(30).WithMessage("Please input at most 30 characters.");
            RuleFor(x => x.Name).MinimumLength(2).WithMessage("Please input at least 2 characters");
            RuleFor(x=>x.ConfirmPassword).Equal(y=>y.Password).WithMessage("Your passwords are not matched");
            RuleFor(x => x.Email).EmailAddress().WithMessage("Please input a proper email adress");

        }
    }
}
