using System;
using System.Collections.Generic;

namespace WebLibrary.Models;

public partial class Status
{
    public int Idstatus { get; set; }

    public string NameStatus { get; set; } = null!;

    public virtual ICollection<Issued> Issueds { get; set; } = new List<Issued>();

    public virtual ICollection<Reservation> Reservations { get; set; } = new List<Reservation>();
}
