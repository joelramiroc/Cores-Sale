// <copyright file="DetailEntryNote.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace CSales.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class DetailEntryNote
    {
        [ForeignKey(nameof(EntryNote))]
        public long IdEntryNote { get; set; }

        public virtual EntryNote EntryNote { get; set; }

        [ForeignKey(nameof(Product))]
        public long IdProduct { get; set; }

        public virtual Product Product { get; set; }

        [ForeignKey(nameof(ReasonEntryNote))]
        public long IdReasonEntryNote { get; set; }

        public virtual ReasonNote ReasonEntryNote { get; set; }

        [ForeignKey(nameof(EntryNoteStatus))]
        public long IdEntryNoteStatus { get; set; }

        public virtual StatusNote EntryNoteStatus { get; set; }

        public int Quantity { get; set; }

        public decimal UnitePrice { get; set; }

        public decimal Total { get; set; }

        public DateTime CreatedDate { get; set; }
    }
}
