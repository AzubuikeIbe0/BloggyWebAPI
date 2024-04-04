using System;
using System.Collections.Generic;

namespace BloggyWebAPI.Models;

public partial class Article
{
    public int Id { get; set; }

    public string? Title { get; set; }

    public string? Subtitle { get; set; }

    public string? Body { get; set; }

    public int? AuthorId { get; set; }

    public string? Category { get; set; }

    public string? ImageUrl { get; set; }

    public int? Views { get; set; }

    public DateTime? CreatedAt { get; set; }

    public virtual Author? Author { get; set; }
}
