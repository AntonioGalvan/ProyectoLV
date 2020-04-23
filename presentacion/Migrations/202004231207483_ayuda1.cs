namespace presentacion.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ayuda1 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Experts", "MyProperty");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Experts", "MyProperty", c => c.Int(nullable: false));
        }
    }
}
