namespace ThirdDatabaseAssignment.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FourthMigration : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Adresses", "Home", c => c.String());
            AddColumn("dbo.Adresses", "Work", c => c.String());
            AddColumn("dbo.Adresses", "Other", c => c.String());
            AddColumn("dbo.Phones", "Home", c => c.String());
            AddColumn("dbo.Phones", "Cellphone", c => c.String());
            AddColumn("dbo.Phones", "Other", c => c.String());
            DropColumn("dbo.Adresses", "Street");
            DropColumn("dbo.Adresses", "Street2");
            DropColumn("dbo.Adresses", "Street3");
            DropColumn("dbo.Phones", "PhoneNr");
            DropColumn("dbo.Phones", "PhoneNr2");
            DropColumn("dbo.Phones", "PhoneNr3");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Phones", "PhoneNr3", c => c.String());
            AddColumn("dbo.Phones", "PhoneNr2", c => c.String());
            AddColumn("dbo.Phones", "PhoneNr", c => c.String());
            AddColumn("dbo.Adresses", "Street3", c => c.String());
            AddColumn("dbo.Adresses", "Street2", c => c.String());
            AddColumn("dbo.Adresses", "Street", c => c.String());
            DropColumn("dbo.Phones", "Other");
            DropColumn("dbo.Phones", "Cellphone");
            DropColumn("dbo.Phones", "Home");
            DropColumn("dbo.Adresses", "Other");
            DropColumn("dbo.Adresses", "Work");
            DropColumn("dbo.Adresses", "Home");
        }
    }
}
