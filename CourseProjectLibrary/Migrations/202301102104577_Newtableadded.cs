namespace CourseProjectLibrary.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Newtableadded : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserID = c.Int(nullable: false, identity: true),
                        UserName = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.UserID);
            
            AlterColumn("dbo.Products", "Qty", c => c.Long(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Products", "Qty", c => c.Int(nullable: false));
            DropTable("dbo.Users");
        }
    }
}
