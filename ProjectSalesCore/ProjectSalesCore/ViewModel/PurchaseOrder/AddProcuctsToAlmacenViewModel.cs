// <copyright file="AddProcuctsToAlmacenController.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace ProjectSalesCore.ViewModel.PurchaseOrder
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;

    public class AddProcuctsToAlmacenViewModel
    {
        public AddProcuctsToAlmacenViewModel()
        {
            this.OrderDetail_IdAlmacenViewModel = new List<OrderDetail_IdAlmacenViewModel>();
        }

        public IEnumerable<OrderDetail_IdAlmacenViewModel> OrderDetail_IdAlmacenViewModel { get; set; }

        public int PurchaseNumber { get; set; }
    }
}