// <copyright file="Voucher.cs" company="PlaceholderCompany">
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

    public class Voucher
    {
        [Key]
        public long IdVoucher { get; set; }

        [ForeignKey(nameof(Client))]
        public long IdClient { get; set; }

        public virtual Client Client { get; set; }

        [ForeignKey(nameof(Employee))]
        public long IdEmployee { get; set; }

        public virtual Employee Employee { get; set; }

        [ForeignKey(nameof(TypeOfSaleDocument))]
        public long IdTypeDocumentForSale { get; set; }

        public virtual TypeOfSaleDocument TypeOfSaleDocument { get; set; }

        public decimal Total { get; set; }
    }
}
