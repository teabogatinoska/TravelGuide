namespace IT_TRAVEL_GUIDE.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class tea2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.AttractionReviews", "CityAttraction_Id", "dbo.CityAttractions");
            DropIndex("dbo.AttractionReviews", new[] { "CityAttraction_Id" });
            DropTable("dbo.AttractionReviews");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.AttractionReviews",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        AttractionRating = c.Int(nullable: false),
                        AttractionReviewText = c.String(nullable: false, maxLength: 1024),
                        AttractionID = c.Int(nullable: false),
                        CityAttraction_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateIndex("dbo.AttractionReviews", "CityAttraction_Id");
            AddForeignKey("dbo.AttractionReviews", "CityAttraction_Id", "dbo.CityAttractions", "Id");
        }
    }
}
