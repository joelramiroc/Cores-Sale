// <copyright file="EntryNote.cs" company="PlaceholderCompany">
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

    public class EntryNote
    {
        [Key]
        public long IdEntryNote { get; set; }

        [ForeignKey(nameof(PurchaseOrder))]
        public long IdPurchaseOrder { get; set; }

        public virtual PurchaseOrder PurchaseOrder { get; set; }

        [ForeignKey(nameof(EntryNoteStatus))]

        public long IdEntryNoteStatus { get; set; }

        public virtual StatusNote EntryNoteStatus { get; set; }

        [ForeignKey(nameof(ReasonNote))]

        public long IdReasonNote { get; set; }

        public virtual ReasonNote ReasonNote { get; set; }

        [ForeignKey(nameof(PurchaseDocument))]

        public long IdPurchaseDocument { get; set; }

        public virtual PurchaseDocument PurchaseDocument { get; set; }
    }
}
