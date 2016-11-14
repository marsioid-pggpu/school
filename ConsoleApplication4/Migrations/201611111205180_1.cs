namespace ConsoleApplication4.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Children",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false),
                        LastName = c.String(nullable: false),
                        PatranomicName = c.String(nullable: false),
                        BDate = c.DateTime(nullable: false),
                        Sex = c.Int(nullable: false),
                        Index = c.String(),
                        City = c.String(nullable: false),
                        Street = c.String(nullable: false),
                        House = c.String(nullable: false),
                        House2 = c.String(),
                        Flat = c.String(),
                        Phone = c.String(),
                        Sertifact = c.String(),
                        CC1 = c.Int(),
                        CC2 = c.Int(),
                        CC3 = c.Int(),
                        CC4 = c.Int(),
                        SvSer1 = c.String(),
                        SvSer2 = c.String(),
                        SvNum = c.String(),
                        SvOther = c.String(),
                        FormOfStudy = c.String(),
                        TypeOfStudy = c.String(),
                        Class_ClassId = c.Int(nullable: false),
                        Nationality_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Classes", t => t.Class_ClassId, cascadeDelete: true)
                .ForeignKey("dbo.Nationalities", t => t.Nationality_Id, cascadeDelete: true)
                .Index(t => t.Class_ClassId)
                .Index(t => t.Nationality_Id);
            
            CreateTable(
                "dbo.Classes",
                c => new
                    {
                        ClassId = c.Int(nullable: false, identity: true),
                        Parallel = c.Int(nullable: false),
                        Litera = c.String(),
                        Note = c.String(),
                        ClassType_Id = c.Int(nullable: false),
                        School_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ClassId)
                .ForeignKey("dbo.ClassTypes", t => t.ClassType_Id, cascadeDelete: true)
                .ForeignKey("dbo.Schools", t => t.School_Id, cascadeDelete: true)
                .Index(t => t.ClassType_Id)
                .Index(t => t.School_Id);
            
            CreateTable(
                "dbo.ClassTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Schools",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Index = c.String(),
                        Street = c.String(),
                        House = c.String(),
                        House2 = c.String(),
                        Phone = c.String(),
                        Boss = c.String(),
                        Locality_Id = c.Int(nullable: false),
                        SchoolType_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Localities", t => t.Locality_Id, cascadeDelete: true)
                .ForeignKey("dbo.SchoolTypes", t => t.SchoolType_Id, cascadeDelete: true)
                .Index(t => t.Locality_Id)
                .Index(t => t.SchoolType_Id);
            
            CreateTable(
                "dbo.Localities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        ShName = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.SchoolTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Nationalities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Children", "Nationality_Id", "dbo.Nationalities");
            DropForeignKey("dbo.Children", "Class_ClassId", "dbo.Classes");
            DropForeignKey("dbo.Classes", "School_Id", "dbo.Schools");
            DropForeignKey("dbo.Schools", "SchoolType_Id", "dbo.SchoolTypes");
            DropForeignKey("dbo.Schools", "Locality_Id", "dbo.Localities");
            DropForeignKey("dbo.Classes", "ClassType_Id", "dbo.ClassTypes");
            DropIndex("dbo.Schools", new[] { "SchoolType_Id" });
            DropIndex("dbo.Schools", new[] { "Locality_Id" });
            DropIndex("dbo.Classes", new[] { "School_Id" });
            DropIndex("dbo.Classes", new[] { "ClassType_Id" });
            DropIndex("dbo.Children", new[] { "Nationality_Id" });
            DropIndex("dbo.Children", new[] { "Class_ClassId" });
            DropTable("dbo.Nationalities");
            DropTable("dbo.SchoolTypes");
            DropTable("dbo.Localities");
            DropTable("dbo.Schools");
            DropTable("dbo.ClassTypes");
            DropTable("dbo.Classes");
            DropTable("dbo.Children");
        }
    }
}
