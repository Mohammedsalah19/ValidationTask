namespace ValidationTask.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initl : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.UserDatas",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Address = c.String(),
                        Email = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.UserDatas");
        }
    }
}
