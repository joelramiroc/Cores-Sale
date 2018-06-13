// <copyright file="ExternalProduct.cs" company="PlaceholderCompany">
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

    [Table("EP")]

    public class EProduct
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("ID")]
        public int Id { get; set; }

        [ForeignKey(nameof(Product))]
        [Column("IDPRODUCT")]
        public int IdProduct { get; set; }

        [Column("PRODUCT")]
        public virtual Product Product { get; set; }

        [ForeignKey(nameof(UnitOfMeasurement))]
        [Column("IDM")]
        public int IdUnitOfMeasurement { get; set; }

        [Column("UNITOFMEASUREMENT")]
        public virtual UOfMeasur UnitOfMeasurement { get; set; }

        [ForeignKey(nameof(ProductType))]
        [Column("IDPT")]
        public int IdProductType { get; set; }

        [Column("PRODUCTTYPE")]
        public virtual ProductType ProductType { get; set; }

        [ForeignKey(nameof(ProductLine))]
        [Column("IDPL")]
        public int IdProductLine { get; set; }

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
