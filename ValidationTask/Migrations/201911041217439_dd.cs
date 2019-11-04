namespace ValidationTask.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dd : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.UserDatas", "Email", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.UserDatas", "Email", c => c.String());
        }
    }
}
