using System;
using System.Collections.Generic;

namespace Data.Models;

public partial class Author
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual Book? Book { get; set; }
}
