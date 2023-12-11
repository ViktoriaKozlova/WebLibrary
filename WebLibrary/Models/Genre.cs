using System;
using System.Collections.Generic;

namespace WebLibrary.Models;

public partial class Genre
{
    public int Idgenre { get; set; }

    public string NameGenre { get; set; } = null!;

    // public virtual ICollection<Book> BookIdbooks { get; set; } = new List<Book>();
}
