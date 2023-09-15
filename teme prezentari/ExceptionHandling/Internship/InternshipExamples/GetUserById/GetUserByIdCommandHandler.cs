using MediatR;

namespace InternshipExamples.GetUserById
{
    public class GetUserByIdCommandHandler : IRequestHandler<GetUserByIdCommand, User>
    {
        public GetUserByIdCommandHandler()
        {
        }

        public Task<User> Handle(GetUserByIdCommand request, CancellationToken cancellationToken)
        {
            return Task.FromResult(Data.Users.FirstOrDefault(x => x.Id == request.UserId));
        }
    }

    public static class Data
    {
        public static IList<User> Users = new List<User>
        {
                new User
                {
                    Id = 1,
                    Name = "John",
                    Email = ""
                },
                new User
                {
                    Id = 2,
                    Name = "Jane",
                    Email = ""
                },
        };
    }
}
