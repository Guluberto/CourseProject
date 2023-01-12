namespace CourseProjectLibrary.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UserAge : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Users", "UserAge", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Users", "UserAge", c => c.String(nullable: false));
        }
    }
}
