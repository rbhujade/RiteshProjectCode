using System;
using System.Collections.Generic;

namespace FluentValidation.Models;

public partial class TempTb
{
    public string PersonName { get; set; } = null!;

    public string? Product { get; set; }

    public string? Country { get; set; }

    public double? Price { get; set; }

    public int Years { get; set; }
}
