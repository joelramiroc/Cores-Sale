// <copyright file="DetailEntryNote.cs" company="PlaceholderCompany">
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

    [Table("DETAILENTRYNOTE")]

    public class DetailEntryNote
    {
        [ForeignKey(nameof(EntryNote))]
        [Column("IDENTRYNOTE")]
        public long IdEntryNote { get; set; }

        [Column("ENTRYNOTE")]
        public virtual EntryNote EntryNote { get; set; }

        [ForeignKey(nameof(Product))]
        [Column("IDPRODUCT")]
        public long IdProduct { get; set; }

        [Column("PRODUCT")]
        public virtual Product Product { get; set; }

        [ForeignKey(nameof(ReasonEntryNote))]
        [Column("IDREASONENTRYNOTE")]
        public long IdReasonEntryNote { get; set; }

        [Column("REASONENTRYNOTE")]
        public virtual ReasonNote ReasonEntryNote { get; set; }

        [ForeignKey(nameof(EntryNoteStatus))]
        [Column("ENTRYNOTESTATUS")]
        public long IdEntryNoteStatus { get; set; }

        [Column("ENTRYNOTESTATUS")]
        public virtual StatusNote EntryNoteStatus { get; set; }

        [Column("QUANTITY")]
        public int Quantity { get; set; }

        [Column("UNITEPRICE")]
        public decimal UnitePrice { get; set; }

        [Column("TOTAL")]
        public decimal Total { get; set; }

        [Column("CREATEDDATE")]
        public DateTime CreatedDate { get; set; }
    }
}
