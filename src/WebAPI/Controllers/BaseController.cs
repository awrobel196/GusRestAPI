using Application.Services.Interfaces;
using Gus;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    public class BaseController : ControllerBase
    {
        protected readonly IAuthorizationService _authorization;
        protected readonly IMediator _mediator;
        protected readonly UslugaBIRzewnPublClient _uslugaBi;



        public BaseController(IAuthorizationService authorization, IMediator mediator, ISetupBinding binding)
        {
            _authorization = authorization;
            _mediator = mediator;
            _uslugaBi = new UslugaBIRzewnPublClient();
            binding.Binding(_uslugaBi);
        }
    }
}
