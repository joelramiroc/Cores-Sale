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

    [Table("SALE")]

    public class Sale
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column("IDSALE")]
        public long IdSale { get; set; }

        [ForeignKey(nameof(SaleOrder))]
        [Column("IDSALEORDER")]
        public long IdSaleOrder { get; set; }

        [Column("SALEORDER")]
        public virtual SaleOrder SaleOrder { get; set; }

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

        [ForeignKey(nameof(OutputNote))]
        [Column("IDNOTEOUTPUT")]
        public long IdNoteOutput { get; set; }

        [Column("OUTPUTNOTE")]
        public OutputNote OutputNote { get; set; }

        [Column("CREATEDDATE")]
        public DateTime CreatedDate { get; set; }
    }
}
