﻿using System;
using System.Collections.Generic;

namespace HW_1._3.Models;

public partial class Product
{
    public Guid Id { get; set; }

    public string Name { get; set; } = null!;

    public double Cost { get; set; }

    public string Description { get; set; } = null!;

    public int Quantity { get; set; }
}
