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

namespace Application.Pkds.Queries
{
    public class GetPkdQuery : BaseQuery, IRequest<List<Pkd>>
    {
        public override string? NazwaRaportu { get; set; } = "BIR11OsPrawnaPkd";
    }

    public class GetPkdQueryHandler : IRequestHandler<GetPkdQuery, List<Pkd>>
    {
        private readonly IXmlResponseConverter _responseConverter;
        public GetPkdQueryHandler(IXmlResponseConverter responseConverter)
        {
            _responseConverter = responseConverter;
        }
        public async Task<List<Pkd>> Handle(GetPkdQuery request, CancellationToken cancellationToken)
        {
            
            try
            {
                var pkdPodmiotu = (await request.GusServices.DanePobierzPelnyRaportAsync(request.Regon,request.NazwaRaportu))
                    .DanePobierzPelnyRaportResult;

                if (String.IsNullOrEmpty(pkdPodmiotu)) return new List<Pkd>();


                var listPkdPodmiotu = await _responseConverter.Convert<Pkd>(pkdPodmiotu);
                return listPkdPodmiotu;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return new();
        }
    }
}
