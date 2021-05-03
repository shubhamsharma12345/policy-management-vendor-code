namespace PolicyManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class policy : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.PolicyVendors", "CertificateIssuedDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.PolicyVendors", "CertificateValidityDate", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.PolicyVendors", "CertificateValidityDate");
            DropColumn("dbo.PolicyVendors", "CertificateIssuedDate");
        }
    }
}
