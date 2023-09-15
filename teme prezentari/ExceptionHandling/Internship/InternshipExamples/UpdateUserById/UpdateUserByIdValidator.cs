using FluentValidation;

namespace InternshipExamples.UpdateUserById
{
    public class UpdateUserByIdValidator : AbstractValidator<UpdateUserByIdCommand>
    {
        public UpdateUserByIdValidator()
        {
            RuleFor(x => x.UserId).GreaterThan(0);
            RuleFor(x => x.Username).NotEmpty();
        }
    }
}
