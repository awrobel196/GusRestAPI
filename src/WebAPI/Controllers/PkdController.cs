﻿using System.Net;
using Application.Extensions;
using Application.Pkds.Queries;
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
    public class PkdController : BaseController
    {

        public PkdController(IAuthorizationService authorization, IMediator mediator, ISetupBinding binding)
            : base(authorization, mediator, binding)
        {

        }

        [HttpGet]
        public async Task<ActionResult<List<Pkd>>> GetAll(string apiKey, string regon)
        {

            if (!regon.IsCorrectRegon()) return UnprocessableEntity("REGON must consisting of 9 characters");
            if (!_authorization.Login(apiKey, _uslugaBi)) return Unauthorized("API Key is incorrect");

            var request = new GetPkdQuery()
            {
                Regon = regon,
                GusServices = _uslugaBi
            };

            var response =  await _mediator.Send(request);


            return response.IsCorrect() ? Ok(response) : NotFound("REGON was not found");
        }
    }
}
