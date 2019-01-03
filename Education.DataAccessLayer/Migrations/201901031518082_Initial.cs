namespace Education.DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CategoryOfSkills",
                c => new
                    {
                        CategoryId = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.CategoryId);
            
            CreateTable(
                "dbo.UserRoles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                        DateOfCreation = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        login = c.String(nullable: false),
                        password = c.String(nullable: false),
                        Name = c.String(),
                        create_date = c.DateTime(nullable: false),
                        gender = c.String(nullable: false),
                        phone_number = c.String(nullable: false),
                        email = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Skills",
                c => new
                    {
                        SkillId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        CategoryId = c.Int(nullable: false),
                        LevelOfSkill = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.SkillId)
                .ForeignKey("dbo.CategoryOfSkills", t => t.CategoryId, cascadeDelete: true)
                .Index(t => t.CategoryId);
            
            CreateTable(
                "dbo.Tasks",
                c => new
                    {
                        TaskId = c.Int(nullable: false, identity: true),
                        StatusOfTask = c.Int(nullable: false),
                        IsCompleted = c.Boolean(nullable: false),
                        StartDate = c.DateTime(nullable: false),
                        FinishDate = c.DateTime(nullable: false),
                        DeadlineDate = c.DateTime(nullable: false),
                        IsFinished = c.Boolean(nullable: false),
                        UserId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.TaskId)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.SkillUsers",
                c => new
                    {
                        Skill_SkillId = c.Int(nullable: false),
                        User_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Skill_SkillId, t.User_Id })
                .ForeignKey("dbo.Skills", t => t.Skill_SkillId, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.User_Id, cascadeDelete: true)
                .Index(t => t.Skill_SkillId)
                .Index(t => t.User_Id);
            
            CreateTable(
                "dbo.UserUserRoles",
                c => new
                    {
                        User_Id = c.Int(nullable: false),
                        UserRole_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.User_Id, t.UserRole_Id })
                .ForeignKey("dbo.Users", t => t.User_Id, cascadeDelete: true)
                .ForeignKey("dbo.UserRoles", t => t.UserRole_Id, cascadeDelete: true)
                .Index(t => t.User_Id)
                .Index(t => t.UserRole_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UserUserRoles", "UserRole_Id", "dbo.UserRoles");
            DropForeignKey("dbo.UserUserRoles", "User_Id", "dbo.Users");
            DropForeignKey("dbo.Tasks", "UserId", "dbo.Users");
            DropForeignKey("dbo.SkillUsers", "User_Id", "dbo.Users");
            DropForeignKey("dbo.SkillUsers", "Skill_SkillId", "dbo.Skills");
            DropForeignKey("dbo.Skills", "CategoryId", "dbo.CategoryOfSkills");
            DropIndex("dbo.UserUserRoles", new[] { "UserRole_Id" });
            DropIndex("dbo.UserUserRoles", new[] { "User_Id" });
            DropIndex("dbo.SkillUsers", new[] { "User_Id" });
            DropIndex("dbo.SkillUsers", new[] { "Skill_SkillId" });
            DropIndex("dbo.Tasks", new[] { "UserId" });
            DropIndex("dbo.Skills", new[] { "CategoryId" });
            DropTable("dbo.UserUserRoles");
            DropTable("dbo.SkillUsers");
            DropTable("dbo.Tasks");
            DropTable("dbo.Skills");
            DropTable("dbo.Users");
            DropTable("dbo.UserRoles");
            DropTable("dbo.CategoryOfSkills");
        }
    }
}
