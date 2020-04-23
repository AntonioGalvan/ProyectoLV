namespace presentacion.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class modificacion2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Experts", "ImageUrl", c => c.String(maxLength: 200));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Experts", "ImageUrl", c => c.String(nullable: false, maxLength: 200));
        }
    }
}
