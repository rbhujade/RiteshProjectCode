using System;
using System.Collections.Generic;

namespace DB_First_EF_Approach.Models;

public partial class AuditPerson
{
    public int Id { get; set; }

    public string? AuditAction { get; set; }
}
