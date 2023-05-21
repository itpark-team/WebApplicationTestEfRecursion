using System;
using System.Collections.Generic;

namespace WebApplicationTestEfRecursion;

public partial class Position
{
    public int Id { get; set; }

    public string Name { get; set; }

    public int Salary { get; set; }

    public virtual ICollection<Worker> Workers { get; set; } = new List<Worker>();
}
