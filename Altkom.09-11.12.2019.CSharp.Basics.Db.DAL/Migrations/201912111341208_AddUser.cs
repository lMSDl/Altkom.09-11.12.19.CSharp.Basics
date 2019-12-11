namespace Altkom._09_11._12._2019.CSharp.Basics.Db.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddUser : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserId = c.Int(nullable: false, identity: true),
                        Username = c.String(maxLength: 128),
                        Password = c.String(nullable: false, maxLength: 60),
                        Email = c.String(nullable: false, maxLength: 254),
                    })
                .PrimaryKey(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Users");
        }
    }
}
