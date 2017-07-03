namespace TestRepo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TestModels",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Test = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.TestModels");
        }
    }
}
