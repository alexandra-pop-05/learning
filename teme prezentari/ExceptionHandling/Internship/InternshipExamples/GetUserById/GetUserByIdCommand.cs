using MediatR;

namespace InternshipExamples.GetUserById
{
    public class GetUserByIdCommand : IRequest<User?>
    {
        public int UserId { get; set; }
    }
}
