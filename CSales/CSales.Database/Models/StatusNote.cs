// <copyright file="EntryNoteStatus.cs" company="PlaceholderCompany">
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

    [Table("STATUSNOTE")]

    public class StatusNote
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column("IDSTATUSNOTE")]
        public long IdStatusNote { get; set; }

        [Column("STATUSNAME")]
        public string StatusName { get; set; }
    }
}
