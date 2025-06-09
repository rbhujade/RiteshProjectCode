using System;
using System.Collections.Generic;

namespace DB_First_EF_Approach.Models;

public partial class Order
{
    public int Id { get; set; }

    public Guid OrderId { get; set; }

    public string OrderName { get; set; } = null!;

    public int Price { get; set; }

    public int Quantity { get; set; }

    public DateTime DateTime { get; set; }
}
