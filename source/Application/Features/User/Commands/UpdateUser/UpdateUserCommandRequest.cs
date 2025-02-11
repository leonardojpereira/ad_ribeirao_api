namespace Project.Application.Features.Commands.UpdateUser
{
    public record UpdateUserCommandRequest
    {
        public string? Username { get; set; }
        public string? Email { get; set; }
        public Guid RoleId { get; set; }
    }
}
