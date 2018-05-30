// <copyright file="CreditNote.cs" company="PlaceholderCompany">
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

    [Table("CREDITNOTE")]

    public class CreditNote
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column("IDCREDITNOTE")]
        public long IdCreditNote { get; set; }

        [ForeignKey(nameof(CreditNoteType))]
        [Column("IDCREDITNOTETYPE")]
        public long IdCreditNoteType { get; set; }

        [Column("CREDITNOTETYPE")]
        public virtual CreditNoteType CreditNoteType { get; set; }

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

        [Column("TOTAL")]
        public decimal Total { get; set; }

        [ForeignKey(nameof(TypeOfSaleDocument))]
        [Column("IDTYPEDOCUENTFORSALE")]
        public long IdTypeDocumentForSale { get; set; }

        [Column("TYPEOFSALEDOCUMENT")]
        public virtual TypeOfSaleDocument TypeOfSaleDocument { get; set; }
    }
}
