using MediatR;

namespace InternshipExamples.UpdateUserById
{
    public class UpdateUserByIdCommand : IRequest<User>
    {
        public int UserId { get; internal set; }
        public string Username { get; internal set; }
    }
}
