using System;
using System.Collections.Generic;

namespace WebAppMovies.Models;

public partial class Movie
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string StarCast { get; set; } = null!;

    public string Producer { get; set; } = null!;

    public DateTime? ReleaseDate { get; set; }
}
