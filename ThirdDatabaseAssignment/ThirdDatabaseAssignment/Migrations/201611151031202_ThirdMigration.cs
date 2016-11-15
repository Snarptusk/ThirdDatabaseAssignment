namespace ThirdDatabaseAssignment.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ThirdMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Adresses",
                c => new
                    {
                        AdressID = c.Int(nullable: false, identity: true),
                        Street = c.String(),
                        Street2 = c.String(),
                        Street3 = c.String(),
                        City = c.String(),
                        Person_PersonID = c.Int(),
                    })
                .PrimaryKey(t => t.AdressID)
                .ForeignKey("dbo.People", t => t.Person_PersonID)
                .Index(t => t.Person_PersonID);
            
            CreateTable(
                "dbo.Phones",
                c => new
                    {
                        PhoneID = c.Int(nullable: false, identity: true),
                        PhoneNr = c.String(),
                        PhoneNr2 = c.String(),
                        PhoneNr3 = c.String(),
                        Person_PersonID = c.Int(),
                    })
                .PrimaryKey(t => t.PhoneID)
                .ForeignKey("dbo.People", t => t.Person_PersonID)
                .Index(t => t.Person_PersonID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Phones", "Person_PersonID", "dbo.People");
            DropForeignKey("dbo.Adresses", "Person_PersonID", "dbo.People");
            DropIndex("dbo.Phones", new[] { "Person_PersonID" });
            DropIndex("dbo.Adresses", new[] { "Person_PersonID" });
            DropTable("dbo.Phones");
            DropTable("dbo.Adresses");
        }
    }
}
