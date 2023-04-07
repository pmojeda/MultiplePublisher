using System;
using System.Collections.Generic;

namespace MultiplePublisher.Data.Models;

public partial class Category
{
    public int IdCategory { get; set; }

    public string Description { get; set; } = null!;

    public int? IdCategoryParent { get; set; }

    public int IdClient { get; set; }

    public virtual ICollection<Product> Products { get; } = new List<Product>();
}
