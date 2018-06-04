// <copyright file="Collections.cs" company="PlaceholderCompany">
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

    [Table("COLLECTION")]

    public class Collection
    {
        [Key]
        [ForeignKey(nameof(Client))]
        [Column("IDCLIENT",Order =0)]
        public long IdClient { get; set; }

        [Column("CLIENT")]
        public virtual Client Client { get; set; }

        [ForeignKey(nameof(PaymentMethod))]
        [Column("IDPAYm")]
        public long IdPayM { get; set; }

        [Column("PAYMENTMETHOD")]
        public virtual PaymentMethod PaymentMethod { get; set; }

        [ForeignKey(nameof(Bank))]
        [Column("IDBANK")]
        public long IdBank { get; set; }

        [Column("BANK")]
        public virtual Bank Bank { get; set; }

        [ForeignKey(nameof(TypeOfSaleDocument))]
        [Column("IDTDFS")]
        public long IdTypeDocumentForSale { get; set; }

        [Column("TYPEOFSALEDOCUMENT")]
        public virtual TypeOfSaleDocument TypeOfSaleDocument { get; set; }

        [Column("IDDOCUMENT")]
        public long IdDocument { get; set; }

        [Key]
        [ForeignKey(nameof(Check))]
        [Column("IDCHECK",Order =1)]
        public long IdCheck { get; set; }

        [Column("CHECK")]
        public virtual Check Check { get; set; }
    }
}
