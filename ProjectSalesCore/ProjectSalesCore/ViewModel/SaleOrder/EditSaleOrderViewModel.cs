namespace ProjectSalesCore.ViewModel.SaleOrder
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using System.Web;
    using CSales.Database.Models;
    using ProjectSalesCore.DataBase.Models;
    using CSales.Models;

    public class EditSaleOrderViewModel
    {
        public long IdSaleOrder { get; set; }

        public long IdClient { get; set; }

        public virtual CSales.Database.Models.Client Client { get; set; }

        public long IdEmployee { get; set; }

        public virtual CSales.Database.Models.Employee Employee { get; set; }

        public long IdPaymentCondition { get; set; }

        public virtual PaymentCondition PaymentCondition { get; set; }

        public IEnumerable<CSales.Database.Models.OrderDetail> OrderDetails { get; set; }
    }
}