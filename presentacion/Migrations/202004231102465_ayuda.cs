namespace presentacion.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ayuda : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Experts", "MyProperty", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Experts", "MyProperty");
        }
    }
}
