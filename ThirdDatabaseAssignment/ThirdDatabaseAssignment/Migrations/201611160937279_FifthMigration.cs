
namespace ThirdDatabaseAssignment.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FifthMigration : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Adresses", new[] { "Person_PersonID" });
            DropIndex("dbo.Phones", new[] { "Person_PersonID" });
            CreateIndex("dbo.Adresses", "person_PersonID");
            CreateIndex("dbo.Phones", "person_PersonID");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Phones", new[] { "person_PersonID" });
            DropIndex("dbo.Adresses", new[] { "person_PersonID" });
            CreateIndex("dbo.Phones", "Person_PersonID");
            CreateIndex("dbo.Adresses", "Person_PersonID");
        }
    }
}
