using System;
using System.Collections.Generic;

namespace MultiplePublisher.Infrastructure.Models;

public partial class Product
{
    public int IdProduct { get; set; }

    public int IdClient { get; set; }

    public string IdProductOfClient { get; set; } = null!;

    public string Description { get; set; } = null!;

    public int IdCategory { get; set; }

    public virtual Category IdCategoryNavigation { get; set; } = null!;

    public virtual Client IdClientNavigation { get; set; } = null!;
}
