namespace CSales.Database.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    [Table("CURRENTACCOUNTDOCUMENTTYPE")]

    public class CurrentAccountDocumentType
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column("IDCURRENTACCOUNTDOCUMENTTYPE")]
        public long IdCurrentAccountDocumentType { get; set; }

        [Column("TYPENAME")]
        public string TypeName { get; set; }
    }
}
