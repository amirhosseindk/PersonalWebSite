using Domain.Entities.Commons;

namespace Domain.Entities.User
{
    public class User : BaseEntity
    {
        public string Email { get; set; } = string.Empty;
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public Address Address { get; set; }
    }
}
