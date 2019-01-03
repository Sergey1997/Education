namespace Education.DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UserMigration : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Skills", "UserProfile_Id", "dbo.UserProfiles");
            DropForeignKey("dbo.AspNetUsers", "Skill_SkillId", "dbo.Skills");
            DropIndex("dbo.Skills", new[] { "UserProfile_Id" });
            DropIndex("dbo.AspNetUsers", new[] { "Skill_SkillId" });
            CreateTable(
                "dbo.UserProfileSkills",
                c => new
                    {
                        UserProfile_Id = c.String(nullable: false, maxLength: 128),
                        Skill_SkillId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.UserProfile_Id, t.Skill_SkillId })
                .ForeignKey("dbo.UserProfiles", t => t.UserProfile_Id, cascadeDelete: true)
                .ForeignKey("dbo.Skills", t => t.Skill_SkillId, cascadeDelete: true)
                .Index(t => t.UserProfile_Id)
                .Index(t => t.Skill_SkillId);
            
            DropColumn("dbo.Skills", "UserProfile_Id");
            DropColumn("dbo.AspNetUsers", "Skill_SkillId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.AspNetUsers", "Skill_SkillId", c => c.Int());
            AddColumn("dbo.Skills", "UserProfile_Id", c => c.String(maxLength: 128));
            DropForeignKey("dbo.UserProfileSkills", "Skill_SkillId", "dbo.Skills");
            DropForeignKey("dbo.UserProfileSkills", "UserProfile_Id", "dbo.UserProfiles");
            DropIndex("dbo.UserProfileSkills", new[] { "Skill_SkillId" });
            DropIndex("dbo.UserProfileSkills", new[] { "UserProfile_Id" });
            DropTable("dbo.UserProfileSkills");
            CreateIndex("dbo.AspNetUsers", "Skill_SkillId");
            CreateIndex("dbo.Skills", "UserProfile_Id");
            AddForeignKey("dbo.AspNetUsers", "Skill_SkillId", "dbo.Skills", "SkillId");
            AddForeignKey("dbo.Skills", "UserProfile_Id", "dbo.UserProfiles", "id");
        }
    }
}
