namespace ClassExercise05032014.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Albums",
                c => new
                    {
                        AlbumId = c.Int(nullable: false, identity: true),
                        AlbumName = c.String(),
                    })
                .PrimaryKey(t => t.AlbumId);
            
            CreateTable(
                "dbo.Tracks",
                c => new
                    {
                        TrackId = c.Int(nullable: false, identity: true),
                        TrackName = c.String(),
                        AlbumId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.TrackId)
                .ForeignKey("dbo.Albums", t => t.AlbumId, cascadeDelete: true)
                .Index(t => t.AlbumId);
            
        }
        
        public override void Down()
        {
            DropIndex("dbo.Tracks", new[] { "AlbumId" });
            DropForeignKey("dbo.Tracks", "AlbumId", "dbo.Albums");
            DropTable("dbo.Tracks");
            DropTable("dbo.Albums");
        }
    }
}
