// <copyright file="PurchaseDocuments.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace CSales.Database.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    [Table("PURCHASEDOCUMENT")]

    public class PurchaseDocument
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column("IDPURCHASEDOCUMENT")]
        public long IdPurchaseDocument { get; set; }

        [ForeignKey(nameof(Provider))]
        [Column("PROVIDER")]
        public long IdProvider { get; set; }

        [Column("PROVIDER")]
        public virtual Provider Provider { get; set; }

        [ForeignKey(nameof(CurrentAccountDocumentType))]
        [Column("IDCURRENTACCOUNTDOCUMENTTYPE")]
        public long IdCurrentAccountDocumentType { get; set; }

        [Column("CURRENTACCOUNTDOCUMENTTYPE")]
        public virtual CurrentAccountDocumentType CurrentAccountDocumentType { get; set; }

        [ForeignKey(nameof(PurchaseOrder))]
        [Column("IDPURCHASEORDER")]
        public long IdPurchaseOrder { get; set; }

        [Column("PURCHASEORDER")]
        public virtual PurchaseOrder PurchaseOrder { get; set; }

        [Column("CREATEDDATE")]
        public DateTime CreatedDate { get; set; }

        [Column("DETAILSPRODUCTSTOSALE")]
        public ICollection<DetailsProductsToSale> DetailsProductsToSale { get; set; }

        [Column("TOTALAMOUNT")]
        public decimal TotalAmount { get; set; }
    }
}
