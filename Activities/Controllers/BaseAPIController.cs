using System;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Activities.Controllers {
	[ApiController]
	[Route("[controller]")]
	public class BaseAPIController : Controller {
		private IMediator _mediator;
		protected IMediator Mediator => _mediator ??= 
			HttpContext.RequestServices.GetService<IMediator>();
	}
}
