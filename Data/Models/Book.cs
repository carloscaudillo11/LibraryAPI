using System;
using System.Collections.Generic;

namespace Data.Models;

public partial class Book
{
    public int Id { get; set; }

    public string Title { get; set; } = null!;

    public int Chapters { get; set; }

    public int Pages { get; set; }

    public decimal Price { get; set; }

    public int AuthorId { get; set; }

    public virtual Author? Author { get; set; } = null!;
}
