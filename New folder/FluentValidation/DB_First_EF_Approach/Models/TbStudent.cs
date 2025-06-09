using System;
using System.Collections.Generic;

namespace DB_First_EF_Approach.Models;

public partial class TbStudent
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string? Course { get; set; }

    public string? Contact { get; set; }
}
