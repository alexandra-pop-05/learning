using FluentValidation;

namespace InternshipExamples.GetUserById
{
    public class GetUserByIdValidator : AbstractValidator<GetUserByIdCommand>
    {
        public GetUserByIdValidator()
        {
            RuleFor(x => x.UserId).GreaterThan(0);
        }
    }
}
