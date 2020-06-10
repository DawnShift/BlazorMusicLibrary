using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ShearedModel.CustoValidators
{
    public class EmailDomainValidator : ValidationAttribute
    {
        public string AllowedDomains { get; set; }
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            string[] strings = value.ToString().Split("@");
            if (strings[1].Length>1&& strings[1].ToUpper() == AllowedDomains)
                return null;
            return new ValidationResult(ErrorMessage, new[] { validationContext.MemberName });
        }
    }
}
