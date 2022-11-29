using System;
using System.Collections.Generic;

namespace WebApplication1.Models;

public partial class UserTable1
{
    public int UserId { get; set; }

    public string UserName { get; set; } = null!;

    public string UserSex { get; set; } = null!;

    public string? Email { get; set; }

    public string Phone { get; set; } = null!;

    public string CellPhone { get; set; } = null!;

    public string Area { get; set; } = null!;

    public string Ability { get; set; } = null!;

    public string UseState { get; set; } = null!;

    public DateTime CreateTime { get; set; }

    public string Modifier { get; set; } = null!;

    public DateTime ChangeTime { get; set; }
}
