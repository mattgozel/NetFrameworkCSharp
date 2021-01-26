namespace DvdLibraryService.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Dvds",
                c => new
                    {
                        DvdId = c.Int(nullable: false, identity: true),
                        Title = c.String(maxLength: 30),
                        ReleaseYear = c.Int(),
                        Director = c.String(maxLength: 30),
                        Rating = c.String(maxLength: 10),
                        Notes = c.String(maxLength: 200),
                    })
                .PrimaryKey(t => t.DvdId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Dvds");
        }
    }
}
