using System;
using System.Collections.Generic;

namespace FluentValidation.Models;

public partial class TbTest
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public DateOnly CreatedDate { get; set; }
}
