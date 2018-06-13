﻿// <copyright file="OrderDetailsComprasViewModel.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace ProjectSalesCore.ViewModel.PurchaseOrder
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using CSales.Database.Models;

    public class OrderDetailsComprasViewModel
    {
        public int Id { get; set; }

        public int IdProduct { get; set; }

        public virtual Product Product { get; set; }

        public int Quantity { get; set; }

        public decimal UnitPrice { get; set; }

        public decimal Discount { get; set; }
    }
}