using System;
using System.Collections.Generic;
namespace WebLibrary.Models;

public partial class User
{
    public int Iduser { get; set; }
    public string FullName { get; set; } = null!;
    public string Email { get; set; } = null!;
    public string Login { get; set; } = null!;
    public string Password { get; set; } = null!;

    public DateOnly Bithday { get; set; }

    public int RoleIdrole { get; set; }
}
