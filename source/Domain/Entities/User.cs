using BCrypt.Net;

namespace Project.Domain.Entities
{
    public class User
    {
        public string Username { get; set; } = string.Empty;
        public string HashedPassword { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public Guid RoleId { get; set; }

        public string? ProfileImage { get; set; }

        public Guid Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public bool IsDeleted { get; set; } = false;
        public virtual Role? Role { get; set; }


        private User() { }

        public User(Guid id, string username, string password, string email, Guid roleId)
        {
            Id = id;
            Username = username;
            HashedPassword = HashPassword(password);
            Email = email;
            RoleId = roleId;
        }

        private string HashPassword(string password)
        {
            return BCrypt.Net.BCrypt.HashPassword(password);
        }

        public bool VerifyPassword(string password)
        {
            return BCrypt.Net.BCrypt.Verify(password, HashedPassword);
        }
    }
}
