namespace CSales.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTestClass : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TESTS",
                c => new
                    {
                        KEY = c.Int(nullable: false),
                        NAME = c.String(),
                    })
                .PrimaryKey(t => t.KEY);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.TESTS");
        }
    }
}
