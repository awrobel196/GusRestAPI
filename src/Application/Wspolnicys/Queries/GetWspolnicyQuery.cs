using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Pkds.Queries;
using Application.Query;
using Application.Services.Interfaces;
using Domain.Models;
using Gus;
using MediatR;

namespace Application.Wspolnicys.Queries
{
    public class GetWspolnicyQuery : BaseQuery, IRequest<List<Wspolnicy>>
    {
        public override string? NazwaRaportu { get; set; } = "BIR11OsPrawnaSpCywilnaWspolnicy";
    }

    public class GetWspolnicyQueryHandler : IRequestHandler<GetWspolnicyQuery, List<Wspolnicy>>
    {
        private readonly IXmlResponseConverter _responseConverter;
        public GetWspolnicyQueryHandler(IXmlResponseConverter responseConverter)
        {
            _responseConverter = responseConverter;
        }
        public async Task<List<Wspolnicy>> Handle(GetWspolnicyQuery request, CancellationToken cancellationToken)
        {

            try
            {
                var wpolnicy = (await request.GusServices.DanePobierzPelnyRaportAsync(request.Regon, request.NazwaRaportu))
                    .DanePobierzPelnyRaportResult;

                if (String.IsNullOrEmpty(wpolnicy)) return new List<Wspolnicy>();


                var listWspolnicy = await _responseConverter.Convert<Wspolnicy>(wpolnicy);
                return listWspolnicy;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return new();
        }
    }
}
