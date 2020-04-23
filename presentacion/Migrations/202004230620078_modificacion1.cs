namespace presentacion.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class modificacion1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Advices", "text", c => c.String());
            AlterColumn("dbo.Profiles", "Name", c => c.String(nullable: false, maxLength: 20));
            AlterColumn("dbo.Profiles", "LastName", c => c.String(nullable: false, maxLength: 30));
            AlterColumn("dbo.Profiles", "UserName", c => c.String(nullable: false, maxLength: 30));
            AlterColumn("dbo.Profiles", "Password", c => c.String(nullable: false, maxLength: 30));
            AlterColumn("dbo.Profiles", "City", c => c.String(nullable: false, maxLength: 25));
            DropColumn("dbo.Advices", "Number");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Advices", "Number", c => c.Int(nullable: false));
            AlterColumn("dbo.Profiles", "City", c => c.String());
            AlterColumn("dbo.Profiles", "Password", c => c.String());
            AlterColumn("dbo.Profiles", "UserName", c => c.String());
            AlterColumn("dbo.Profiles", "LastName", c => c.String());
            AlterColumn("dbo.Profiles", "Name", c => c.String());
            DropColumn("dbo.Advices", "text");
        }
    }
}
