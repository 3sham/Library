namespace Library.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatetablebooksetimagepathnullable : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Books", "ImagePath", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Books", "ImagePath", c => c.String(nullable: false));
        }
    }
}
