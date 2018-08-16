namespace ASPdotNETBlog.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddModelValidations : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Articles", "Name", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Articles", "Text", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Articles", "Text", c => c.String());
            AlterColumn("dbo.Articles", "Name", c => c.String());
        }
    }
}
