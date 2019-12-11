namespace Altkom._09_11._12._2019.CSharp.Basics.Db.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPerson : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.People",
                c => new
                    {
                        PersonId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.PersonId)
                .ForeignKey("dbo.Users", t => t.PersonId)
                .Index(t => t.PersonId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.People", "PersonId", "dbo.Users");
            DropIndex("dbo.People", new[] { "PersonId" });
            DropTable("dbo.People");
        }
    }
}
