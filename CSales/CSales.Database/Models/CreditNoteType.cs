// <copyright file="CreditNoteType.cs" company="PlaceholderCompany">
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

    [Table("CREDITNOTETYPE")]

    public class CreditNoteType
    {
        [Key]
        [Column("IDCREDITNOTETYPE")]
        public long IdCreditNoteType { get; set; }

        [Column("TYPECREDITNOTENAME")]
        public string TypeCreditNoteName { get; set; }
    }
}
