namespace Penso.Persistance.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Init3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "Email", c => c.String());
            DropColumn("dbo.Users", "Emailu");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Users", "Emailu", c => c.String());
            DropColumn("dbo.Users", "Email");
        }
    }
}
