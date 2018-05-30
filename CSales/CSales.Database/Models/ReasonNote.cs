// <copyright file="ReasonEntryNote.cs" company="PlaceholderCompany">
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

    [Table("REASONNOTE")]

    public class ReasonNote
    {
        [Key]
        [Column("IDREASONENTRYNOTE")]
        public long IdReasonEntryNote { get; set; }

        [Column("REASONNAME")]
        public string ReasonName { get; set; }
    }
}
