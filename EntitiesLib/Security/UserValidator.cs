using FluentValidation;
using MVCHIS.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCHIS.Security {
    public class UserValidator : BaseValidator<UserModel> {
        public UserValidator() {
            RuleFor(x => x.FullName)
                            .Cascade(CascadeMode.StopOnFirstFailure)
                            .NotEmpty()                .WithMessage("{PropertyName} cannot be empty")
                            .Length(5,50)              .WithMessage("{PropertyName} Length({Length}) must be between 5 and 50")
                            .Must(BeValidName)         .WithMessage("{PropertyName} cannot contain numeric or special characters")
                            ;
            RuleFor(x => x.UserName)
                            .Cascade(CascadeMode.StopOnFirstFailure)
                            .NotEmpty()
                            .Length(6, 10)
                            .Must(BeValidName)
                            ;
            RuleFor(x => x.UserPassword)
                            .NotEmpty()
                            ;

        }
    }
}
