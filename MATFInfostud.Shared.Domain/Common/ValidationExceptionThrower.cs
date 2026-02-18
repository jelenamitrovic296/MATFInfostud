using MATFInfostud.Shared.Domain.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using FluentValidation.Results;


namespace MATFInfostud.Shared.Domain.Common
{
    public class ValidationExceptionThrower : IValidationExceptionThrower
    {
        public void ThrowValidationException(string name, string message)
        {
            throw new FluentValidation.ValidationException(
                new List<ValidationFailure> {
                new(name,message)
                }
            );
        }
    }

}
