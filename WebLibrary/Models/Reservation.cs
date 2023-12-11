using System;
using System.Collections.Generic;

namespace WebLibrary.Models;

public partial class Reservation
{
    public int Idreservation { get; set; }

    public DateOnly DateReserv { get; set; }

    public DateOnly DateEndReserv { get; set; }

    public sbyte Use { get; set; }

    public int UserIduser { get; set; }

    public int BookIdbook { get; set; }

    public int StatusIdstatus { get; set; }

 //   public virtual Book BookIdbookNavigation { get; set; } = null!;

  //  public virtual Status StatusIdstatusNavigation { get; set; } = null!;

  //   public virtual User UserIduserNavigation { get; set; } = null!;
}
