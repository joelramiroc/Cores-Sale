// <copyright file="EntryNote.cs" company="PlaceholderCompany">
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

    [Table("ENTRYNOTE")]

    public class EntryNote
    {
        [Key]
        [Column("IDENTRYNOTE")]
        public long IdEntryNote { get; set; }

        [ForeignKey(nameof(PurchaseOrder))]
        [Column("IDPURCHASEORDER")]
        public long IdPurchaseOrder { get; set; }

        [Column("PURCHASEORDER")]
        public virtual PurchaseOrder PurchaseOrder { get; set; }

        [ForeignKey(nameof(EntryNoteStatus))]
        [Column("IDENTRYNOTESTATUS")]
        public long IdEntryNoteStatus { get; set; }

        [Column("ENTRYNOTESTATUS")]
        public virtual StatusNote EntryNoteStatus { get; set; }

        [ForeignKey(nameof(ReasonNote))]
        [Column("IDREASONNOTE")]
        public long IdReasonNote { get; set; }

        [Column("REASONNOTE")]
        public virtual ReasonNote ReasonNote { get; set; }

        [ForeignKey(nameof(PurchaseDocument))]
        [Column("IDPURCHASEDOCUMENT")]
        public long IdPurchaseDocument { get; set; }

        [Column("PURCHASEDOCUMENT")]
        public virtual PurchaseDocument PurchaseDocument { get; set; }
    }
}
