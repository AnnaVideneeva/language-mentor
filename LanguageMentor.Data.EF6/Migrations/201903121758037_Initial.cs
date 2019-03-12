namespace LanguageMentor.Data.EF6.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "LanguageMentorDb.answers",
                c => new
                    {
                        answer_id = c.Int(nullable: false, identity: true),
                        answer_text = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.answer_id);
            
            CreateTable(
                "LanguageMentorDb.point_answer_pool",
                c => new
                    {
                        point_answer_pool_id = c.Int(nullable: false, identity: true),
                        point_id = c.Int(nullable: false),
                        answer_id = c.Int(nullable: false),
                        is_correct_answer = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.point_answer_pool_id)
                .ForeignKey("LanguageMentorDb.answers", t => t.answer_id, cascadeDelete: true)
                .ForeignKey("LanguageMentorDb.points", t => t.point_id, cascadeDelete: true)
                .Index(t => t.point_id)
                .Index(t => t.answer_id);
            
            CreateTable(
                "LanguageMentorDb.points",
                c => new
                    {
                        point_id = c.Int(nullable: false, identity: true),
                        point_text = c.String(nullable: false, maxLength: 256),
                        exercise_id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.point_id)
                .ForeignKey("LanguageMentorDb.exercises", t => t.exercise_id, cascadeDelete: true)
                .Index(t => t.exercise_id);
            
            CreateTable(
                "LanguageMentorDb.exercises",
                c => new
                    {
                        exercise_id = c.Int(nullable: false, identity: true),
                        exercise_text = c.String(nullable: false, maxLength: 256),
                        level_id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.exercise_id)
                .ForeignKey("LanguageMentorDb.levels", t => t.level_id, cascadeDelete: true)
                .Index(t => t.level_id);
            
            CreateTable(
                "LanguageMentorDb.exercise_examination_pool",
                c => new
                    {
                        exercise_examination_pool_id = c.Int(nullable: false, identity: true),
                        exercise_id = c.Int(nullable: false),
                        examination_id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.exercise_examination_pool_id)
                .ForeignKey("LanguageMentorDb.examinations", t => t.examination_id, cascadeDelete: true)
                .ForeignKey("LanguageMentorDb.exercises", t => t.exercise_id, cascadeDelete: true)
                .Index(t => t.exercise_id)
                .Index(t => t.examination_id);
            
            CreateTable(
                "LanguageMentorDb.examinations",
                c => new
                    {
                        examination_id = c.Int(nullable: false, identity: true),
                        description = c.String(nullable: false, maxLength: 256),
                        examination_type_id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.examination_id)
                .ForeignKey("LanguageMentorDb.examination_types", t => t.examination_type_id, cascadeDelete: true)
                .Index(t => t.examination_type_id);
            
            CreateTable(
                "LanguageMentorDb.examination_types",
                c => new
                    {
                        examination_type_id = c.Int(nullable: false, identity: true),
                        type = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.examination_type_id);
            
            CreateTable(
                "LanguageMentorDb.levels",
                c => new
                    {
                        level_id = c.Int(nullable: false, identity: true),
                        level_name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.level_id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("LanguageMentorDb.point_answer_pool", "point_id", "LanguageMentorDb.points");
            DropForeignKey("LanguageMentorDb.points", "exercise_id", "LanguageMentorDb.exercises");
            DropForeignKey("LanguageMentorDb.exercises", "level_id", "LanguageMentorDb.levels");
            DropForeignKey("LanguageMentorDb.exercise_examination_pool", "exercise_id", "LanguageMentorDb.exercises");
            DropForeignKey("LanguageMentorDb.exercise_examination_pool", "examination_id", "LanguageMentorDb.examinations");
            DropForeignKey("LanguageMentorDb.examinations", "examination_type_id", "LanguageMentorDb.examination_types");
            DropForeignKey("LanguageMentorDb.point_answer_pool", "answer_id", "LanguageMentorDb.answers");
            DropIndex("LanguageMentorDb.examinations", new[] { "examination_type_id" });
            DropIndex("LanguageMentorDb.exercise_examination_pool", new[] { "examination_id" });
            DropIndex("LanguageMentorDb.exercise_examination_pool", new[] { "exercise_id" });
            DropIndex("LanguageMentorDb.exercises", new[] { "level_id" });
            DropIndex("LanguageMentorDb.points", new[] { "exercise_id" });
            DropIndex("LanguageMentorDb.point_answer_pool", new[] { "answer_id" });
            DropIndex("LanguageMentorDb.point_answer_pool", new[] { "point_id" });
            DropTable("LanguageMentorDb.levels");
            DropTable("LanguageMentorDb.examination_types");
            DropTable("LanguageMentorDb.examinations");
            DropTable("LanguageMentorDb.exercise_examination_pool");
            DropTable("LanguageMentorDb.exercises");
            DropTable("LanguageMentorDb.points");
            DropTable("LanguageMentorDb.point_answer_pool");
            DropTable("LanguageMentorDb.answers");
        }
    }
}
