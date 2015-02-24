namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AllTables : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.GroupToSubjects",
                c => new
                    {
                        GroupId = c.Int(nullable: false),
                        SubjectId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.GroupId, t.SubjectId })
                .ForeignKey("dbo.Groups", t => t.GroupId, cascadeDelete: true)
                .ForeignKey("dbo.Subjects", t => t.SubjectId, cascadeDelete: true)
                .Index(t => t.GroupId)
                .Index(t => t.SubjectId);
            
            CreateTable(
                "dbo.Subjects",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Age = c.Int(nullable: false),
                        GroupId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Groups", t => t.GroupId, cascadeDelete: true)
                .Index(t => t.GroupId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Students", "GroupId", "dbo.Groups");
            DropForeignKey("dbo.GroupToSubjects", "SubjectId", "dbo.Subjects");
            DropForeignKey("dbo.GroupToSubjects", "GroupId", "dbo.Groups");
            DropIndex("dbo.Students", new[] { "GroupId" });
            DropIndex("dbo.GroupToSubjects", new[] { "SubjectId" });
            DropIndex("dbo.GroupToSubjects", new[] { "GroupId" });
            DropTable("dbo.Students");
            DropTable("dbo.Subjects");
            DropTable("dbo.GroupToSubjects");
        }
    }
}
