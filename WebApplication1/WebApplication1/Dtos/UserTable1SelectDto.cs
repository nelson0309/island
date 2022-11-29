using System.Threading.Tasks;

namespace WebApplication1.Dtos
{
    public class UserTable1SelectDto
    {
        public int UserId { get; set; }

        public string UserName { get; set; } = null!;

        public string UserSex { get; set; } = null!;

        public string? Email { get; set; }

        public string Phone { get; set; } = null!;

        public string CellPhone { get; set; } = null!;

        public string Area { get; set; } = null!;

        public string Ability { get; set; } = null!;

        public DateTime CreateTime { get; set; }

        public string Modifier { get; set; } = null!;

        public DateTime ChangeTime { get; set; }
    }
}
