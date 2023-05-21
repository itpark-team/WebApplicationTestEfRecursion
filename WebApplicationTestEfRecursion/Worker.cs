using System;
using System.Collections.Generic;

namespace WebApplicationTestEfRecursion;

public partial class Worker
{
    public int Id { get; set; }

    public string Name { get; set; }

    public virtual ICollection<Position> Positions { get; set; } = new List<Position>();
}
