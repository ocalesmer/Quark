using Application.Base;
using AvvaMobile.Core.Business;
using Core.Caching;
using Core.Resources;
using FluentValidation;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Localization;
using Persistence.Contexts;

namespace Application.Features.someFeature.Commands.CreateSomeFeature
{
    public class CreateCustomerCommand : IRequest<ServiceResult>
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        public string MobilePhone { get; set; }
        public string ProfilePhotoUrl { get; set; }
        public IFormFile ProfilePhoto { get; set; }
    }
    public class CreateCustomerCommandHandler : BaseHandler, IRequestHandler<CreateCustomerCommand, ServiceResult>
    {

        public CreateCustomerCommandHandler(IHttpContextAccessor httpContext, BaseDbContext context, IStringLocalizer<CommonResource> localizer, AppSettingsKeys appSettingsKeys) : base(httpContext, context, localizer, appSettingsKeys)
        {

        }

        public async Task<ServiceResult> Handle(CreateCustomerCommand request, CancellationToken cancellationToken)
        {
            var result = new ServiceResult();
            var customer = await _context.Customers.ToListAsync();
            return result;
        }
    }
    public class CreateCustomerCommandValidator : AbstractValidator<CreateCustomerCommand>
    {
        public CreateCustomerCommandValidator(IStringLocalizer<CommonResource> _localizer)
        {
            RuleFor(x => x.Firstname).NotNull().WithMessage(x => _localizer["ValidationForRequired"]);
            RuleFor(x => x.Lastname).NotNull().WithMessage(x => _localizer["ValidationForRequired"]);
            RuleFor(x => x.Email).EmailAddress().NotNull().WithMessage(x => _localizer["ValidationForRequired"]);
            RuleFor(x => x.MobilePhone).NotNull().WithMessage(x => _localizer["ValidationForRequired"]);
        }
    }
}