using System;
using System.Collections.Generic;

namespace DB_First_EF_Approach.Models;

public partial class TbProduct
{
    public int ProductId { get; set; }

    public string ProductName { get; set; } = null!;

    public int Category { get; set; }

    public virtual ICollection<TbInventory> TbInventories { get; set; } = new List<TbInventory>();
}
