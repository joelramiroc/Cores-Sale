﻿// <copyright file="Bill.cs" company="PlaceholderCompany">
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

    [Table("BILL")]

    public class Bill
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("ID")]
        public int IdBill { get; set; }

        [ForeignKey(nameof(Client))]
        [Column("IDCLIENT")]
        public int IdClient { get; set; }

        [Column("CLIENT")]
        public virtual Client Client { get; set; }

        [ForeignKey(nameof(Employee))]
        [Column("IDEMPLOYEE")]
        public int IdEmployee { get; set; }

        [Column("EMPLOYEE")]
        public virtual Employee Employee { get; set; }

        [Column("CREATEDDATE")]
        public DateTime CreatedDate { get; set; }

        [Column("ORDERSDETAIL")]
        public ICollection<OrderDetailsVentas> OrdersDetail { get; set; }

        [Column("TOTAL")]
        public decimal Total { get; set; }
    }
}
