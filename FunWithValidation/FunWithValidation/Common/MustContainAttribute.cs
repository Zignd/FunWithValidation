using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FunWithValidation.Common
{
    public class MustContainAttribute : ValidationAttribute, IClientValidatable
    {
        public MustContainAttribute(string text)
        {
            Text = text;
        }

        public string Text { get; set; }

        public override bool IsValid(object value)
        {
            if (value is string)
                return ((string)value).Contains(Text);

            return false;
        }

        public IEnumerable<ModelClientValidationRule> GetClientValidationRules(ModelMetadata metadata, ControllerContext context)
        {
            var rule = new ModelClientValidationRule();
            rule.ErrorMessage = FormatErrorMessage(metadata.GetDisplayName());
            rule.ValidationParameters.Add("text", Text);
            rule.ValidationType = "mustcontain";
            yield return rule;
        }
    }
}