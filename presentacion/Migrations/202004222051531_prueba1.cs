namespace presentacion.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class prueba1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Advices",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Number = c.Int(nullable: false),
                    Author = c.String(),
                    Profile_Id = c.Int(),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Profiles", t => t.Profile_Id)
                .Index(t => t.Profile_Id);

            CreateTable(
                "dbo.Profiles",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Name = c.String(),
                    LastName = c.String(),
                    Age = c.Int(nullable: false),
                    UserName = c.String(),
                    Password = c.String(),
                    City = c.String(),
                    Contact_Id = c.Int(),
                    Expert_Id = c.Int(),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Contacts", t => t.Contact_Id)
                .ForeignKey("dbo.Experts", t => t.Expert_Id)
                .Index(t => t.Contact_Id)
                .Index(t => t.Expert_Id);

            CreateTable(
                "dbo.Contacts",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Phone = c.Int(nullable: false),
                    Email = c.String(),
                })
                .PrimaryKey(t => t.Id);

            CreateTable(
                "dbo.Experts",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Name = c.String(),
                    LastName = c.String(),
                    UserName = c.String(),
                    Email = c.String(),
                    Password = c.String(),
                    Degree = c.String(),
                })
                .PrimaryKey(t => t.Id);

            CreateTable(
                "dbo.Updates",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Reciclyng = c.Double(nullable: false),
                    PollutionReduction = c.Double(nullable: false),
                    Ecology = c.Double(nullable: false),
                    ActiveParticipation = c.Double(nullable: false),
                    Profile_Id = c.Int(),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Profiles", t => t.Profile_Id)
                .Index(t => t.Profile_Id);

        }

        public override void Down()
        {
            DropForeignKey("dbo.Updates", "Profile_Id", "dbo.Profiles");
            DropForeignKey("dbo.Profiles", "Expert_Id", "dbo.Experts");
            DropForeignKey("dbo.Profiles", "Contact_Id", "dbo.Contacts");
            DropForeignKey("dbo.Advices", "Profile_Id", "dbo.Profiles");
            DropIndex("dbo.Updates", new[] { "Profile_Id" });
            DropIndex("dbo.Profiles", new[] { "Expert_Id" });
            DropIndex("dbo.Profiles", new[] { "Contact_Id" });
            DropIndex("dbo.Advices", new[] { "Profile_Id" });
            DropTable("dbo.Updates");
            DropTable("dbo.Experts");
            DropTable("dbo.Contacts");
            DropTable("dbo.Profiles");
            DropTable("dbo.Advices");
        }
    }
}
