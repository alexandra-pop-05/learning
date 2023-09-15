using FluentValidation;
using MediatR;

namespace LoanPal.Directory.Application.Behaviors
{
    public class ValidationBehavior<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse> where TRequest : IRequest<TResponse>
    {
        private readonly ILoggerFactory _loggerFactory;
        private readonly IEnumerable<IValidator<TRequest>> _validators;

        public ValidationBehavior(IServiceProvider serviceProvider, ILoggerFactory loggerFactory)
        {
            _loggerFactory = loggerFactory;
            _validators = serviceProvider.GetServices<IValidator<TRequest>>();
        }

        public async Task<TResponse> Handle(TRequest request, RequestHandlerDelegate<TResponse> next, CancellationToken cancellationToken)
        {
            foreach (var validator in _validators)
            {
                await validator.ValidateAndThrowAsync(request, cancellationToken: cancellationToken);
            }

            return await next();
        }
    }
}
