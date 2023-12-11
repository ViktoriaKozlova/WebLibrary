using System;
using System.Collections.Generic;

namespace WebLibrary.Models;

public partial class Issued
{
    public int Idissued { get; set; }

    public DateOnly DateStart { get; set; }

    public DateOnly DateEnd { get; set; }

    public int UserIduser { get; set; }

    public int BookIdbook { get; set; }

    public int StatusIdstatus { get; set; }

  //  public virtual Book BookIdbookNavigation { get; set; } = null!;

   // public virtual Status StatusIdstatusNavigation { get; set; } = null!;

   // public virtual User UserIduserNavigation { get; set; } = null!;
}
