using System;
using System.Collections.Generic;

namespace MVC_Core_Project.Database;

public partial class Product
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public decimal Price { get; set; }
}
