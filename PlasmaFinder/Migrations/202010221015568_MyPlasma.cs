namespace PlasmaFinder.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MyPlasma : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PlasmaUsers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Username = c.String(nullable: false, maxLength: 15),
                        Email = c.String(),
                        Phone = c.String(),
                        Location = c.String(),
                        BloodGroup = c.String(),
                        Date = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.PlasmaUsers");
        }
    }
}
