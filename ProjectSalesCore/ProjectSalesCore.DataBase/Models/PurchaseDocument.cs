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

    [Table("PDOC")]

    public class PDoc
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("ID")]
        public long Id { get; set; }

        [ForeignKey(nameof(Provider))]
        [Column("PROVIDER")]
        public long IdProvider { get; set; }

        [Column("PROVIDER")]
        public virtual Provider Provider { get; set; }

        [ForeignKey(nameof(CurrentAccountDocumentType))]
        [Column("IDDT")]
        public long IdCurrentAccountDocumentType { get; set; }

        [Column("CURRENTACCOUNTDOCUMENTTYPE")]
        public virtual CurrentAccountDocumentType CurrentAccountDocumentType { get; set; }

        [ForeignKey(nameof(PurchaseOrder))]
        [Column("NPORDER")]
        public int NumberPurchaseOrder { get; set; }

        [Column("PURCHASEORDER")]
        public virtual POrder PurchaseOrder { get; set; }

        [Column("CREATEDDATE")]
        public DateTime CreatedDate { get; set; }

        [Column("DP")]
        public ICollection<DPToSale> DPTSales { get; set; }

        [Column("TOTALAMOUNT")]
        public decimal TotalAmount { get; set; }
    }
}
