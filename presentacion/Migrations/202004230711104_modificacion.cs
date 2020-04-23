namespace presentacion.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class modificacion : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Experts", "ImageUrl", c => c.String(nullable: false, maxLength: 200));
            AlterColumn("dbo.Profiles", "Name", c => c.String(nullable: false, maxLength: 20));
            AlterColumn("dbo.Profiles", "LastName", c => c.String(nullable: false, maxLength: 30));
            AlterColumn("dbo.Experts", "Name", c => c.String(nullable: false, maxLength: 20));
            AlterColumn("dbo.Experts", "LastName", c => c.String(nullable: false, maxLength: 30));
            AlterColumn("dbo.Experts", "UserName", c => c.String(nullable: false, maxLength: 20));
            AlterColumn("dbo.Experts", "Email", c => c.String(nullable: false, maxLength: 40));
            AlterColumn("dbo.Experts", "Password", c => c.String(nullable: false, maxLength: 20));
            AlterColumn("dbo.Experts", "Degree", c => c.String(nullable: false, maxLength: 20));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Experts", "Degree", c => c.String());
            AlterColumn("dbo.Experts", "Password", c => c.String());
            AlterColumn("dbo.Experts", "Email", c => c.String());
            AlterColumn("dbo.Experts", "UserName", c => c.String());
            AlterColumn("dbo.Experts", "LastName", c => c.String());
            AlterColumn("dbo.Experts", "Name", c => c.String());
            AlterColumn("dbo.Profiles", "LastName", c => c.String());
            AlterColumn("dbo.Profiles", "Name", c => c.String());
            DropColumn("dbo.Experts", "ImageUrl");
        }
    }
}
