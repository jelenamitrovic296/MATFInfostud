using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MATFInfostud.Shared.Domain.Common.Interfaces;

public interface IValidationExceptionThrower
{
    void ThrowValidationException(string name, string message);
}
