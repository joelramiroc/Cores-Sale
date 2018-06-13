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
    using ProjectSalesCore.DataBase.Models;

    [Table("PORDER")]

    public class POrder
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("ID")]
        public int PurchaseNumber { get; set; }

        [Column("PLACEOFENTRY")]
        public string PlaceOfEntry { get; set; }

        [ForeignKey(nameof(Provider))]
        [Column("IDPROVIDER")]
        public int IdProvider { get; set; }

        [Column("PROVIDER")]
        public virtual Provider Provider { get; set; }

        [Column("CREATEDDATE")]
        public DateTime CreatedDate { get; set; }

        [Column("DTS")]
        public ICollection<OrderDetailsCompras> OrderDetailsCompras { get; set; }
    }
}