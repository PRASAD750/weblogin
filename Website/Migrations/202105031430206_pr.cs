namespace Website.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class pr : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Admins", "CreatedDate", c => c.DateTime(nullable: false, precision: 7, storeType: "datetime2"));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Admins", "CreatedDate", c => c.DateTime(nullable: false));
        }
    }
}
