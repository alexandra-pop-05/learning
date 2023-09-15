using InternshipExamples.GetUserById;
using MediatR;

namespace InternshipExamples.UpdateUserById
{
    public class UpdateUserByIdCommandHandler : IRequestHandler<UpdateUserByIdCommand, User>
    {
        public Task<User> Handle(UpdateUserByIdCommand request, CancellationToken cancellationToken)
        {
            Data.Users.FirstOrDefault(x => x.Id == request.UserId).Name = request.Username;

            return Task.FromResult(Data.Users.FirstOrDefault(x => x.Id == request.UserId));
        }
    }
}
