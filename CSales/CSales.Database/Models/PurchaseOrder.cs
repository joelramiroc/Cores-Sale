﻿// <copyright file="PurchaseOrder.cs" company="PlaceholderCompany">
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

    [Table("PURCHASEORDER")]

    public class PurchaseOrder
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column("PURCHASENUMBER")]
        public int PurchaseNumber { get; set; }

        [Column("PLACEOFENTRY")]
        public string PlaceOfEntry { get; set; }

        [ForeignKey(nameof(Provider))]
        [Column("IDPROVIDER")]
        public long IdProvider { get; set; }

        [Column("PROVIDER")]
        public virtual Provider Provider { get; set; }

        [Column("CREATEDDATE")]
        public DateTime CreatedDate { get; set; }

        [Column("DETAILSPRODUCTSTOSALE")]
        public ICollection<DetailsProductsToSale> DetailsProductsToSale { get; set; }
    }
}
