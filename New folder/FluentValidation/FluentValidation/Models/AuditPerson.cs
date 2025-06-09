using System;
using System.Collections.Generic;

namespace FluentValidation.Models;

public partial class AuditPerson
{
    public int Id { get; set; }

    public string? AuditAction { get; set; }
}
