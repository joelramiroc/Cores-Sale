namespace ProjectSalesCore.ViewModel.PDocs
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

    public class EditPDocViewModel
    {
        public long Id { get; set; }

        public long IdProvider { get; set; }

        public virtual CSales.Database.Models.Provider Provider { get; set; }

        public long IdCurrentAccountDocumentType { get; set; }

        public virtual CSales.Database.Models.CurrentAccountDocumentType CurrentAccountDocumentType { get; set; }

        public int NumberPurchaseOrder { get; set; }

        public virtual PurchaseOrder PurchaseOrder { get; set; }

        public IEnumerable<DetailsProductsToSale> DPTSales { get; set; }

        [DisplayFormat(DataFormatString = "{0:c}")]
        public decimal TotalAmount { get; set; }
    }
}