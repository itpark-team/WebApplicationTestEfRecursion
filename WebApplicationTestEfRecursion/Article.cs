using System;
using System.Collections.Generic;

namespace WebApplicationTestEfRecursion;

public partial class Article
{
    public int Id { get; set; }

    public string Title { get; set; }

    public string Content { get; set; }

    public int AuthorId { get; set; }

    public virtual Author Author { get; set; }
}
