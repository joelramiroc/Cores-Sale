// <copyright file="OutputNote.cs" company="PlaceholderCompany">
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

    [Table("ONOTE")]

    public class OutputNote
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column("IDONOTE")]
        public long IdOutputNote { get; set; }

        [ForeignKey(nameof(SaleOrder))]
        [Column("IDSALEORDER")]
        public long IdSaleOrder { get; set; }

        [Column("SALEORDER")]
        public virtual SaleOrder SaleOrder { get; set; }

        [ForeignKey(nameof(OutputNoteStatus))]
        [Column("IDONSTATUS")]
        public long IdOutputNoteStatus { get; set; }

        [Column("OUTPUTNOTESTATUS")]
        public virtual StatusNote OutputNoteStatus { get; set; }

        [ForeignKey(nameof(ReasonNote))]
        [Column("IDRNOTE")]
        public long IdReasonNote { get; set; }

        [Column("REASONNOTE")]
        public virtual ReasonNote ReasonNote { get; set; }

        [ForeignKey(nameof(Bill))]
        [Column("IDBILL")]
        public long IdBill { get; set; }

        [Column("BILL")]
        public virtual Bill Bill { get; set; }
    }
}
