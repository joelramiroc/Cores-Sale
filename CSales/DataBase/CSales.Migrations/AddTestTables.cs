using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSales.Migrations
{
    public class AddTestTables : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "TESTS",
                c => new
                {

                    Key = c.Int(nullable: false, identity: true),
                    Name = c.String()
                }
                ).PrimaryKey(t => t.Key); 
        }

        public override void Down()
        {
            DropTable("TESTS");
        }
    }
}
