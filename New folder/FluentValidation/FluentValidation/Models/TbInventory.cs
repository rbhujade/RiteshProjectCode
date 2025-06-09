using System;
using System.Collections.Generic;

namespace FluentValidation.Models;

public partial class TbInventory
{
    public int InventoryId { get; set; }

    public int ProductId { get; set; }

    public string? InventoryName { get; set; }

    public int? Quantity { get; set; }

    public int? MinLevel { get; set; }

    public int? MaxLevel { get; set; }

    public virtual TbProduct Product { get; set; } = null!;
}
