namespace EntityAquarium.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddAquaLifes : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AquaticLives",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Type = c.String(),
                        Color = c.String(),
                        Name = c.String(),
                        DateAdded = c.DateTime(nullable: false),
                        InQuarantine = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.AquaticLives");
        }
    }
}
