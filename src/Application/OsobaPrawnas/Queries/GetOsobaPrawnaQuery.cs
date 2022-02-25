using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Query;
using Application.Services.Interfaces;
using Domain.Models;
using Gus;
using MediatR;

namespace Application.OsobaPrawnas.Queries
{
    public class GetOsobaPrawnaQuery : BaseQuery, IRequest<OsobaPrawna>
    {
        public override string? NazwaRaportu { get; set; } = "BIR11OsPrawna";
    }

    public class GetOsobaPrawnaQueryHandler : IRequestHandler<GetOsobaPrawnaQuery, OsobaPrawna>
    {
        private readonly IXmlResponseConverter _responseConverter;
        public GetOsobaPrawnaQueryHandler(IXmlResponseConverter responseConverter)
        {
            _responseConverter = responseConverter;
        }
        public async Task<OsobaPrawna> Handle(GetOsobaPrawnaQuery request, CancellationToken cancellationToken)
        {
            
            try
            {
                var osobaPrawna = (await request.GusServices.DanePobierzPelnyRaportAsync(request.Regon,request.NazwaRaportu))
                    .DanePobierzPelnyRaportResult;

                if (String.IsNullOrEmpty(osobaPrawna)) return new OsobaPrawna();


                return (await _responseConverter.Convert<OsobaPrawna>(osobaPrawna)).First();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return new();
        }
    }
}
