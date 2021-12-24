namespace venntest.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PriceType : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Product", "Price", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Product", "Price", c => c.Single(nullable: false));
        }
    }
}
