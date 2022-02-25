using System.ServiceModel.Channels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;
using Application.Query;
using Application.Services;
using Application.Services.Interfaces;
using Domain.Models;
using Gus;
using MediatR;

namespace Application.Podmiots.Queries
{
    public class GetPodmiotQuery :BaseQuery, IRequest<Podmiot>
    {
        
    }
    public class GetPodmiotQueryHandler : IRequestHandler<GetPodmiotQuery, Podmiot>
    {
        private readonly IXmlResponseConverter _responseConverter;
        public GetPodmiotQueryHandler(IXmlResponseConverter responseConverter)
        {
            _responseConverter = responseConverter;
        }
        public async Task<Podmiot> Handle(GetPodmiotQuery request, CancellationToken cancellationToken)
        {

            ParametryWyszukiwania parametry = new()
            {
                Nip = request.Nip
            };

            try
            {
                var danePodmiotu = (await request.GusServices.DaneSzukajPodmiotyAsync(parametry))
                    .DaneSzukajPodmiotyResult;

                if (String.IsNullOrEmpty(danePodmiotu)) return new Podmiot();

                return (await _responseConverter.Convert<Podmiot>(danePodmiotu)).First();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return new();
        }

       


    }
}
