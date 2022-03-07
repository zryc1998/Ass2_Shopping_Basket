namespace Ass2_Shopping_Basket.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update_user_fields : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "FirstName", c => c.String(nullable: false, maxLength: 50));
            AddColumn("dbo.AspNetUsers", "LastName", c => c.String(nullable: false, maxLength: 50));
            AddColumn("dbo.AspNetUsers", "DateOfBirth", c => c.DateTime(nullable: false));
            AddColumn("dbo.AspNetUsers", "Address_AddressLine1", c => c.String(nullable: false));
            AddColumn("dbo.AspNetUsers", "Address_AddressLine2", c => c.String());
            AddColumn("dbo.AspNetUsers", "Address_Town", c => c.String(nullable: false));
            AddColumn("dbo.AspNetUsers", "Address_Country", c => c.String(nullable: false));
            AddColumn("dbo.AspNetUsers", "Address_PostCode", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "Address_PostCode");
            DropColumn("dbo.AspNetUsers", "Address_Country");
            DropColumn("dbo.AspNetUsers", "Address_Town");
            DropColumn("dbo.AspNetUsers", "Address_AddressLine2");
            DropColumn("dbo.AspNetUsers", "Address_AddressLine1");
            DropColumn("dbo.AspNetUsers", "DateOfBirth");
            DropColumn("dbo.AspNetUsers", "LastName");
            DropColumn("dbo.AspNetUsers", "FirstName");
        }
    }
}
