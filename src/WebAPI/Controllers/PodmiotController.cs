using System.Net;
using Application.Extensions;
using Application.Podmiots.Queries;
using Application.Services;
using Application.Services.Interfaces;
using Domain.Models;
using Gus;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PodmiotController : BaseController
    {

        public PodmiotController(IAuthorizationService authorization, IMediator mediator, ISetupBinding binding)
            : base(authorization, mediator, binding)
        {

        }

        [HttpGet]
        public async Task<ActionResult<Podmiot>> GetSingle(string apiKey, string nip)
        {

            if (!nip.IsCorrectNip()) return UnprocessableEntity("NIP must consisting of 10 characters");
            if (!_authorization.Login(apiKey, _uslugaBi)) return Unauthorized("API Key is incorrect");

            var request = new GetPodmiotQuery()
            {
                Nip = nip,
                GusServices = _uslugaBi
            };

            var response =  await _mediator.Send(request);


            return response.IsCorrect() ? Ok(response) : NotFound("NIP was not found");
        }
    }
}
