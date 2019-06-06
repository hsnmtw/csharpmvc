using FluentValidation;
using FluentValidation.Results;
using MVCHIS.Common;
using MVCHIS.Utils.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using ValidatorLib.Common;

namespace MVCHIS.Common {
    public class BaseValidator<M> : AbstractValidator<M> where M:BaseModel {
        
        public BaseValidator() {
        //    RuleFor(x => x.Id==0 ? x.CreatedBy : x.UpdatedBy)
        //        .NotNull()
        //        .NotEmpty()
        //        .WithMessage("VALIDATION ERROR: {PropertyName} - " + ErrorCodes.V_7001_NULL_OR_EMPTY_VALUE_IS_NOT_ACCEPTED);

        //    RuleFor(x => x.Id == 0 ? x.CreatedOn : x.UpdatedOn)
        //            .NotNull()
        //            .NotEmpty()
        //            .Must(BeTodaysDate)
        //            .WithMessage("VALIDATION ERROR: {PropertyName} - " + ErrorCodes.V_7002_DATE_MUST_BE_OF_TODAYS_DATE)
        //            ;
        }

        public BaseValidator(MetaData metadata) : this() {
            var required = metadata.RequiredFields;

            foreach (var propertyName in required.Where(x => !(x.Length > 2 && x.EndsWith("Id")))) {
                RuleFor(x => x)
                    .CustomNotEmpty(typeof(M).GetProperty(propertyName))
                    .WithMessage($"{propertyName} - { ErrorCodes.V_7001_NULL_OR_EMPTY_VALUE_IS_NOT_ACCEPTED }")
                    ;
            }

            foreach (var propertyName in required.Where(x=>x.Length>2 && x.EndsWith("Id"))) {
                RuleFor(x => x)
                    .CustomNotZero(typeof(M).GetProperty(propertyName))
                    .WithMessage($"{propertyName} - { ErrorCodes.V_7004_FIELD_DOES_NOT_ACCEPT_ZERO_VALUES }")
                    ;
            }
        }

        public virtual bool BeTodaysDate(DateTime? d) {
            return d.Diff(DateTime.Now).Days == 0;
        }

        public virtual bool BeValidName(string name) {
            return name
                    .Replace(" ", "")
                    .Replace("-", "")
                    .Replace(".", "")
                    .All(Char.IsLetter);
        }
    }
}
