namespace CourseProjectLibrary.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _123 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "UserAge", c => c.String(nullable: false));
            AddColumn("dbo.Users", "BirthDate", c => c.DateTime(nullable: false));
            DropColumn("dbo.Users", "BornOn");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Users", "BornOn", c => c.DateTime(nullable: false));
            DropColumn("dbo.Users", "BirthDate");
            DropColumn("dbo.Users", "UserAge");
        }
    }
}
