namespace PhonebookApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreatePhonebook : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Phonebooks",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        PhoneNumber = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Phonebooks");
        }
    }
}
