using System;
using System.Collections.Generic;

namespace DB_First_EF_Approach.Models;

public partial class TbEmployee
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string? Address { get; set; }
}
