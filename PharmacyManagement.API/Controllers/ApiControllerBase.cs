

namespace PharmacyManagement.API.Controllers
{
    using MediatR;
    using Microsoft.AspNetCore.Mvc;
    using System.Threading.Tasks;

    public class ApiControllerBase : ControllerBase
    {
        private readonly IMediator _mediator;

        public ApiControllerBase(IMediator mediator)
        {
            _mediator = mediator;
        }

        protected async Task<TResult> CommandAsync<TResult>(IRequest<TResult> command)
        {
            return await _mediator.Send(command);
        }

        protected async Task<ActionResult<TResult>> QueryAsync<TResult>(IRequest<TResult> query)
        {
            return await this._mediator.Send(query);
        }
    }
}
