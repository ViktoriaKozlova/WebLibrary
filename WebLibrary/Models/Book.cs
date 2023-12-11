using System;
using System.Collections.Generic;

namespace WebLibrary.Models;

public partial class Book
{
    public int Idbook { get; set; }

    public string Name { get; set; } = null!;

    public DateOnly Date { get; set; }

    public string Language { get; set; } = null!;

    public int Page { get; set; }

    public int Count { get; set; }

}
