// <copyright file="PurchaseDocuments.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace CSales.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class PurchaseDocument
    {
        [Key]
        public long IdPurchaseDocument { get; set; }

        [ForeignKey(nameof(Provider))]
        public long IdProvider { get; set; }

        public virtual Provider Provider { get; set; }

        [ForeignKey(nameof(CurrentAccountDocumentType))]
        public long IdCurrentAccountDocumentType { get; set; }

        public virtual CurrentAccountDocumentType CurrentAccountDocumentType { get; set; }

        [ForeignKey(nameof(PurchaseOrder))]
        public long IdPurchaseOrder { get; set; }

        public virtual PurchaseOrder PurchaseOrder { get; set; }

        public DateTime CreatedDate { get; set; }

        public ICollection<DetailsProductsToSale> DetailsProductsToSale { get; set; }

        public decimal TotalAmount { get; set; }
    }
}
