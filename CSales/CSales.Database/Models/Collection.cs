// <copyright file="Collections.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace CSales.Database.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Collection
    {
        [ForeignKey(nameof(Client))]
        public long IdClient { get; set; }

        public virtual Client Client { get; set; }

        [ForeignKey(nameof(PaymentMethod))]
        public long IdPaymentMethod { get; set; }

        public virtual PaymentMethod PaymentMethod { get; set; }

        [ForeignKey(nameof(Bank))]
        public long IdBank { get; set; }

        public virtual Bank Bank { get; set; }

        [ForeignKey(nameof(TypeOfSaleDocument))]
        public long IdTypeDocumentForSale { get; set; }

        public virtual TypeOfSaleDocument TypeOfSaleDocument { get; set; }

        public long IdDocument { get; set; }

        [ForeignKey(nameof(Check))]
        public long IdCheck { get; set; }

        public virtual Check Check { get; set; }
    }
}
