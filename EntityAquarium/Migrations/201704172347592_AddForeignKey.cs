namespace EntityAquarium.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddForeignKey : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AquaticLives", "AquariumId", c => c.Int());
            CreateIndex("dbo.AquaticLives", "AquariumId");
            AddForeignKey("dbo.AquaticLives", "AquariumId", "dbo.Aquaria", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AquaticLives", "AquariumId", "dbo.Aquaria");
            DropIndex("dbo.AquaticLives", new[] { "AquariumId" });
            DropColumn("dbo.AquaticLives", "AquariumId");
        }
    }
}
