using System;
using System.Collections.Generic;

namespace WebLibrary.Models;

public partial class Role
{
    public int Idrole { get; set; }

    public string NameRole { get; set; } = null!;

   // public virtual ICollection<User> Users { get; set; } = new List<User>();
}
