namespace CourseProjectLibrary.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NewColumnsAdded : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "AuthorName", c => c.String(nullable: false));
            AddColumn("dbo.Products", "AddedIntoStorage", c => c.DateTime(nullable: false));
            AddColumn("dbo.Products", "Quantity", c => c.Long(nullable: false));
            AddColumn("dbo.Users", "BirthDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Users", "Remarks", c => c.String());
            DropColumn("dbo.Products", "Qty");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Products", "Qty", c => c.Long(nullable: false));
            DropColumn("dbo.Users", "Remarks");
            DropColumn("dbo.Users", "BirthDate");
            DropColumn("dbo.Products", "Quantity");
            DropColumn("dbo.Products", "AddedIntoStorage");
            DropColumn("dbo.Products", "AuthorName");
        }
    }
}
