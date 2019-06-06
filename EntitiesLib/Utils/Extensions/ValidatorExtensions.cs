using FluentValidation;
using FluentValidation.Validators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MVCHIS.Utils.Extensions {

    public static class ValidatorExtensions {
        public static IRuleBuilderOptions<T, T> CustomNotEmpty<T>(
            this IRuleBuilder<T, T> ruleBuilder, PropertyInfo propertyInfo) {
            return ruleBuilder.SetValidator(new CustomNotEmpty<T>(propertyInfo));
        }

        public static IRuleBuilderOptions<T, T> CustomNotZero<T>(
            this IRuleBuilder<T, T> ruleBuilder, PropertyInfo propertyInfo) {
            return ruleBuilder.SetValidator(new CustomNotZero<T>(propertyInfo));
        }
    }



    public class CustomNotEmpty<T> : PropertyValidator {
        private PropertyInfo _propertyInfo;

        public CustomNotEmpty(PropertyInfo propertyInfo) 
            : base(string.Format("{0} is required", propertyInfo.Name)) {
            _propertyInfo = propertyInfo;
        }

        protected override bool IsValid(PropertyValidatorContext context) {
            return !IsNullOrEmpty(_propertyInfo, (T)context.Instance);
        }

        private bool IsNullOrEmpty(PropertyInfo property, T obj) {
            var v = property.GetValue(obj);
            return null == v || "".Equals($"{v}");
        }
    }

    public class CustomNotZero<T> : PropertyValidator {
        private PropertyInfo _propertyInfo;

        public CustomNotZero(PropertyInfo propertyInfo)
            : base(string.Format("{0} is required", propertyInfo.Name)) {
            _propertyInfo = propertyInfo;
        }

        protected override bool IsValid(PropertyValidatorContext context) {
            return !IsNullOrEmpty(_propertyInfo, (T)context.Instance);
        }

        private bool IsNullOrEmpty(PropertyInfo property, T obj) {
            var v = property.GetValue(obj);
            return null == v || "".Equals($"{v}") || "0".Equals($"{v}");
        }
    }


}
