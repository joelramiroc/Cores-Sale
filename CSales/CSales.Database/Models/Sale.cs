// <copyright file="Sale.cs" company="PlaceholderCompany">
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

    public class Sale
    {
        [Key]
        public long IdSale { get; set; }

        [ForeignKey(nameof(SaleOrder))]
        public long IdSaleOrder { get; set; }

        public virtual SaleOrder SaleOrder { get; set; }

        [ForeignKey(nameof(Client))]
        public long IdClient { get; set; }

        public virtual Client Client { get; set; }

        [ForeignKey(nameof(Employee))]
        public long IdEmployee { get; set; }

        public virtual Employee Employee { get; set; }

        [ForeignKey(nameof(NoteOutput))]
        public long IdNoteOutput { get; set; }

        public virtual NoteOutput NoteOutput { get; set; }

        public DateTime CreatedDate { get; set; }
    }
}
