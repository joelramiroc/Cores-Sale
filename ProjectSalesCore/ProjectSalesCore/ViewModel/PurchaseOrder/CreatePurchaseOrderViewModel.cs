﻿// <copyright file="CreatePurchaseOrder.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace ProjectSalesCore.ViewModel.PurchaseOrder
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using CSales.Database.Models;
    using ProjectSalesCore.DataBase.Models;

    public class CreatePurchaseOrderViewModel
    {
        public CreatePurchaseOrderViewModel()
        {
            this.OrderDetailsCompras = new List<OrderDetailsComprasViewModel>();
            this.OrderDetailsComprasViewModel = new OrderDetailsComprasViewModel();
        }

        public int PurchaseNumber { get; set; }

        public string PlaceOfEntry { get; set; }

        public int IdProvider { get; set; }

        public CSales.Database.Models.Provider Providers { get; set; }

        public DateTime CreatedDate { get; set; }

        public virtual Product Product { get; set; }

        public int IdProduct { get; set; }

        public int IdPaymentCondition { get; set; }

        public virtual PCondition PCondition { get; set; }

        public IEnumerable<OrderDetailsComprasViewModel> OrderDetailsCompras { get; set; }

        public IEnumerable<Product> Products { get; set; }

        public OrderDetailsComprasViewModel OrderDetailsComprasViewModel { get; set; }
    }
}