using System;
using System.Collections.Generic;

namespace BloggyWebAPI.Models;

public partial class Author
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? ImageUrl { get; set; }

    public virtual ICollection<Article> Articles { get; set; } = new List<Article>();
}
