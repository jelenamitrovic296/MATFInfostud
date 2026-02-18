using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MATFInfostud.Oglasi.Application.Commands.AktivirajOglas
{
    public class AktivirajOglasCommand : IRequest<bool>
    {
        public required int Id { get; set; }
    }
}
