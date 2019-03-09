namespace PhonebookApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreatePhonebook1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Phonebooks", "PhoneNumber", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Phonebooks", "PhoneNumber", c => c.Int(nullable: false));
        }
    }
}
