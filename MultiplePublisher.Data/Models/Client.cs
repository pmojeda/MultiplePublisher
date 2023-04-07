using System;
using System.Collections.Generic;

namespace MultiplePublisher.Data.Models;

public partial class Client
{
    public int IdClient { get; set; }

    public long TaxId { get; set; }

    public string Description { get; set; } = null!;

    public virtual ICollection<Product> Products { get; } = new List<Product>();
}
