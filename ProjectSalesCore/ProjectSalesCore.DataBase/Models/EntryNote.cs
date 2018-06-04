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

    [Table("ENOTE")]

    public class EntryNote
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column("ID")]
        public long IdEntryNote { get; set; }

        [ForeignKey(nameof(PurchaseOrder))]
        [Column("NPO")]
        public int NumberPurchaseOrder { get; set; }

        [Column("PURCHASEORDER")]
        public virtual PurchaseOrder PurchaseOrder { get; set; }

        [ForeignKey(nameof(EntryNoteStatus))]
        [Column("IDENST")]
        public long IdEntryNoteStatus { get; set; }

        [Column("ENTRYNOTESTATUS")]
        public virtual StatusNote EntryNoteStatus { get; set; }

        [ForeignKey(nameof(ReasonNote))]
        [Column("IDRNOTE")]
        public long IdReasonNote { get; set; }

        [Column("REASONNOTE")]
        public virtual ReasonNote ReasonNote { get; set; }

        [ForeignKey(nameof(PDoc))]
        [Column("IDPDOC")]
        public long IdPurchaseDocument { get; set; }

        [Column("PDOC")]
        public virtual PDoc PDoc { get; set; }
    }
}
