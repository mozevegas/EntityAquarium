namespace EntityAquarium.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class LinkLifeandHome : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.AquaticLives", "AquariumId", "dbo.Aquaria");
            DropIndex("dbo.AquaticLives", new[] { "AquariumId" });
            AddColumn("dbo.AquaticLives", "Aquarium_Id", c => c.Int());
            AddColumn("dbo.AquaticLives", "CityLives_Id", c => c.Int());
            AddColumn("dbo.Aquaria", "AquaticLife_Id", c => c.Int());
            CreateIndex("dbo.AquaticLives", "Aquarium_Id");
            CreateIndex("dbo.AquaticLives", "CityLives_Id");
            CreateIndex("dbo.Aquaria", "AquaticLife_Id");
            AddForeignKey("dbo.AquaticLives", "Aquarium_Id", "dbo.Aquaria", "Id");
            AddForeignKey("dbo.Aquaria", "AquaticLife_Id", "dbo.AquaticLives", "Id");
            AddForeignKey("dbo.AquaticLives", "CityLives_Id", "dbo.Aquaria", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AquaticLives", "CityLives_Id", "dbo.Aquaria");
            DropForeignKey("dbo.Aquaria", "AquaticLife_Id", "dbo.AquaticLives");
            DropForeignKey("dbo.AquaticLives", "Aquarium_Id", "dbo.Aquaria");
            DropIndex("dbo.Aquaria", new[] { "AquaticLife_Id" });
            DropIndex("dbo.AquaticLives", new[] { "CityLives_Id" });
            DropIndex("dbo.AquaticLives", new[] { "Aquarium_Id" });
            DropColumn("dbo.Aquaria", "AquaticLife_Id");
            DropColumn("dbo.AquaticLives", "CityLives_Id");
            DropColumn("dbo.AquaticLives", "Aquarium_Id");
            CreateIndex("dbo.AquaticLives", "AquariumId");
            AddForeignKey("dbo.AquaticLives", "AquariumId", "dbo.Aquaria", "Id");
        }
    }
}
