namespace Project.Application.Features.Commands.UpdateUser
{
    public record UpdateUserCommandResponse
    {
        public Guid Id { get; set; }
        public string Username { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
    }
}
