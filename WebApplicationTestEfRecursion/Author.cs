using System;
using System.Collections.Generic;

namespace WebApplicationTestEfRecursion;

public partial class Author
{
    public int Id { get; set; }

    public string Name { get; set; }

    public int Age { get; set; }

    public virtual ICollection<Article> Articles { get; set; } = new List<Article>();
}
