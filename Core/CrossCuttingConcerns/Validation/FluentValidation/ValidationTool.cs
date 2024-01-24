using FluentValidation;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.CrossCuttingConcerns.Validation.FluentValidation
{
    public class ValidationTool 
    {
        public static void Validate(IValidator validator, object objectToValidate)
        {
            ValidationContext<object> context = new(objectToValidate); //İlgili nesneyi validate etmek için tanımlıyoruz.
            ValidationResult result = validator.Validate(context); //İlgili validataor ile ilgili nesneyi validate ediyoruz.

            if (!result.IsValid)
                throw new ValidationException(result.Errors);

        }
    }
}
