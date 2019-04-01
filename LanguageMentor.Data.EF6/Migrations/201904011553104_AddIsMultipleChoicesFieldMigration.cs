namespace LanguageMentor.Data.EF6.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddIsMultipleChoicesFieldMigration : DbMigration
    {
        public override void Up()
        {
            AddColumn("LanguageMentorDb.points", "is_multiple_choices", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("LanguageMentorDb.points", "is_multiple_choices");
        }
    }
}
