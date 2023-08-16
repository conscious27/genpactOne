﻿using System;
using System.Collections.Generic;

namespace BookApp.Models;

public partial class Author
{
    public int Aid { get; set; }

    public string Author1 { get; set; } = null!;

    public virtual ICollection<Book> Books { get; set; } = new List<Book>();
}
