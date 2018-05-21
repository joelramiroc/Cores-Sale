using FirebirdSql.Data.FirebirdClient;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CSales.Contexts
{
    public class MyContext : DbContext
    {
        public MyContext()
            : base(new FbConnection(@"database=localhost:C:\BASE\TEST.FDB;user=SYSDBA;password=masterkey"), true)
        { }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
        
        public DbSet<Test> Test{ get; set; }
    }

    [Table("TESTS")]
    public class Test
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column("KEY")]
        public int Key { get; set; }

        [Column("NAME")]
        public string Name { get; set; }
    }

}