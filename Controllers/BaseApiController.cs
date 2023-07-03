using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace paypal_sharp.Controllers
{
    public class BaseApiController<T>: ControllerBase
    {
        private IMediator _mediator;
        private ILogger<T> _logger;
        protected IMapper _mapper;
        public IConfiguration _configuration;

        protected IMediator Mediator => _mediator ??= HttpContext.RequestServices.GetService<IMediator>();
        protected ILogger<T> Logger => _logger ??= HttpContext.RequestServices.GetService<ILogger<T>>();
        protected IMapper Mapper => _mapper ??= HttpContext.RequestServices.GetService<IMapper>();
        protected IConfiguration Configuration => _configuration ??= HttpContext.RequestServices.GetService<IConfiguration>();
    }
}
