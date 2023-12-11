using System;
using System.Collections.Generic;

namespace WebLibrary.Models;

public partial class Autor
{
    public int Idautor { get; set; }

    public string FullName { get; set; } = null!;

    public DateOnly Dithday { get; set; }

    public string Biography { get; set; } = null!;

 //   public virtual ICollection<Book> BookIdbooks { get; set; } = new List<Book>();
}
