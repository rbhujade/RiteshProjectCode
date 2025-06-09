using System;
using System.Collections.Generic;

namespace DB_First_EF_Approach.Models;

public partial class Person
{
    public string PersonName { get; set; } = null!;

    public string? Product { get; set; }

    public string? Country { get; set; }

    public double? Price { get; set; }

    public int Years { get; set; }
}
