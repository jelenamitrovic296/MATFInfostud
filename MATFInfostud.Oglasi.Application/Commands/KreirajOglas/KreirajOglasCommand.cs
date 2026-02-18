using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MATFInfostud.Oglasi.Domain.Enums;
using MATFInfostud.Shared.Domain.Common;
using MediatR;

namespace MATFInfostud.Oglasi.Application.Commands.KreirajOglas
{
    public class KreirajOglasCommand : IRequest<int>
    {

        public required int KompanijaId { get; init; }

        public required string Naslov { get; init; }
        public string? Opis { get; init; }
        public required string Pozicija { get; init; }

        public DateTime? DatumIsteka { get; init; }

        public TipZaposlenja TipZaposlenja { get; init; }
        public RadnoVreme RadnoVreme { get; init; }
        public Senioritet Senioritet { get; init; }

        public int? IskustvoMin { get; set; }
        public int? IskustvoMax { get; set; }
        public required string Grad { get; init; }
        public string? Drzava { get; init; }
        public TipRada TipRada { get; init; }
        public double? PlataOd { get; set; }
        public double? PlataDo { get; set; }
        public string? Valuta { get; set; }
        public bool? PlataVidljiva { get; set; }
    }
}
