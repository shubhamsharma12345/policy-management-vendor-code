namespace PolicyManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class poicymanagement : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PolicyAdmins",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        FirstName = c.String(nullable: false),
                        LastName = c.String(),
                        DateOfBirth = c.DateTime(nullable: false),
                        Gender = c.String(nullable: false),
                        ContactNumber = c.Long(nullable: false),
                        EmailId = c.String(nullable: false),
                        Password = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.UserId);
            
            CreateTable(
                "dbo.PolicyUsers",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        FirstName = c.String(nullable: false, maxLength: 50),
                        LastName = c.String(),
                        Gender = c.String(nullable: false),
                        DateOfBirth = c.DateTime(nullable: false),
                        ContactNumber = c.Long(nullable: false),
                        EmailId = c.String(nullable: false),
                        Password = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.UserId);
            
            CreateTable(
                "dbo.PolicyVendors",
                c => new
                    {
                        PolicyVendorRegNo = c.String(nullable: false, maxLength: 100),
                        VendorName = c.String(nullable: false, maxLength: 100),
                        DateOfBirth = c.DateTime(nullable: false),
                        PolicyType = c.String(nullable: false),
                        Address = c.String(),
                        Country = c.String(),
                        State = c.String(),
                        Zip = c.String(),
                        EmailId = c.String(nullable: false),
                        ContactNumber = c.Long(nullable: false),
                        VendorWebsite = c.String(),
                        YearofEstablishment = c.Int(nullable: false),
                        VendorStatus = c.Int(),
                        Password = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.PolicyVendorRegNo);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.PolicyVendors");
            DropTable("dbo.PolicyUsers");
            DropTable("dbo.PolicyAdmins");
        }
    }
}
