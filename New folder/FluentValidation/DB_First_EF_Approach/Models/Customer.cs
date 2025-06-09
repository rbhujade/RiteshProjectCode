using System;
using System.Collections.Generic;

namespace DB_First_EF_Approach.Models;

public partial class Customer
{
    public int CustomerId { get; set; }

    public string? CustomerName { get; set; }

    public string? PhoneNo { get; set; }
}
