// <copyright file="InternalProduct.cs" company="PlaceholderCompany">
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

    [Table("IPDCT")]

    public class IProduct
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("ID")]
        public long IdInternalProduct { get; set; }

        [ForeignKey(nameof(Product))]
        [Column("IDPRODUCT")]
        public long IdProduct { get; set; }

        [Column("PRODUCT")]
        public virtual Product Product { get; set; }

        [ForeignKey(nameof(UOMeasur))]
        [Column("IDUM")]
        public long IdUnitOfMeasurement { get; set; }

        [Column("UOMEAUS")]
        public virtual UOfMeasur UOMeasur { get; set; }

        [ForeignKey(nameof(ProductType))]
        [Column("IDDCT")]
        public long IdProductType { get; set; }

        [Column("PRODUCTTYPE")]
        public virtual ProductType ProductType { get; set; }

        [ForeignKey(nameof(CostCenter))]
        [Column("IDCC")]
        public long IdCostCenter { get; set; }

        [Column("COSTCENTER")]
        public virtual CostCenter CostCenter { get; set; }

        [ForeignKey(nameof(ProductLine))]
        [Column("IDPL")]
        public long IdProductLine { get; set; }

        [Column("PRODUCTLINE")]
        public virtual ProductLine ProductLine { get; set; }

        [Column("PRODUCTDESCRIPTION")]
        public string ProductDescription { get; set; }

        [Column("QUANTITY")]
        public int Quantity { get; set; }

        [Column("ACTIVE")]
        public bool Active { get; set; }
    }
}
