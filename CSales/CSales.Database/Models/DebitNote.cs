﻿// <copyright file="DebitNote.cs" company="PlaceholderCompany">
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

    [Table("DEBITNOTE")]

    public class DebitNote
    {
        [Key]
        [Column("IDDEBITNOTE")]
        public long IdDebitNote { get; set; }

        [ForeignKey(nameof(Client))]
        [Column("IDCLIENT")]
        public long IdClient { get; set; }

        [Column("CLIENT")]
        public virtual Client Client { get; set; }

        [ForeignKey(nameof(Employee))]
        [Column("IDEMPLOYEE")]
        public long IdEmployee { get; set; }

        [Column("EMPLOYEE")]
        public virtual Employee Employee { get; set; }

        [ForeignKey(nameof(TypeOfSaleDocument))]
        [Column("IDTYPEDOCUMENTFORSALE")]
        public long IdTypeDocumentForSale { get; set; }

        [Column("TYPEOFSALEDOCUMENT")]
        public virtual TypeOfSaleDocument TypeOfSaleDocument { get; set; }

        [Column("IDDOCUMENT")]
        public long IdDocument { get; set; }

        [Column("TOTAL")]
        public decimal Total { get; set; }
    }
}
