namespace presentacion.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class modificacionAdviceUser : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Advices", "Author", c => c.String());
            AddColumn("dbo.Advices", "text", c => c.String());
            AddColumn("dbo.Advices", "User_Id", c => c.Int());
            CreateIndex("dbo.Advices", "User_Id");
            AddForeignKey("dbo.Advices", "User_Id", "dbo.Users", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Advices", "User_Id", "dbo.Users");
            DropIndex("dbo.Advices", new[] { "User_Id" });
            DropColumn("dbo.Advices", "User_Id");
            DropColumn("dbo.Advices", "text");
            DropColumn("dbo.Advices", "Author");
        }
    }
}
