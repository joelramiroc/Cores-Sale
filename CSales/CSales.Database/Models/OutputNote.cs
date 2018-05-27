// <copyright file="OutputNote.cs" company="PlaceholderCompany">
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

    public class OutputNote
    {
        [Key]
        public long IdOutputNote { get; set; }

        [ForeignKey(nameof(SaleOrder))]
        public long IdSaleOrder { get; set; }

        public virtual SaleOrder SaleOrder { get; set; }

        [ForeignKey(nameof(OutputNoteStatus))]

        public long IdOutputNoteStatus { get; set; }

        public virtual StatusNote OutputNoteStatus { get; set; }

        [ForeignKey(nameof(ReasonNote))]

        public long IdReasonNote { get; set; }

        public virtual ReasonNote ReasonNote { get; set; }

        [ForeignKey(nameof(Bill))]

        public long IdBill { get; set; }

        public virtual Bill Bill { get; set; }
    }
}
