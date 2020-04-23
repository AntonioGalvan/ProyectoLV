namespace presentacion.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class inicio : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Advices", "text", c => c.String());
            DropColumn("dbo.Advices", "Number");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Advices", "Number", c => c.Int(nullable: false));
            DropColumn("dbo.Advices", "text");
        }
    }
}
