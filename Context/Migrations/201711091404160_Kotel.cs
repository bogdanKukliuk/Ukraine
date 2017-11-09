namespace Context.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Kotel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.InfoBooks",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NameBook = c.String(nullable: false, maxLength: 255),
                        NameAuthor = c.String(nullable: false, maxLength: 255),
                        Price = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 255),
                        Age = c.Int(nullable: false),
                        Mony = c.Int(nullable: false),
                        Email = c.String(nullable: false, maxLength: 228),
                        Password = c.String(nullable: false, maxLength: 228),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.librarians",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 228),
                        Post = c.String(nullable: false, maxLength: 228),
                        Debtors = c.String(nullable: false, maxLength: 228),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.UserInfoBooks",
                c => new
                    {
                        User_Id = c.Int(nullable: false),
                        InfoBook_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.User_Id, t.InfoBook_Id })
                .ForeignKey("dbo.Users", t => t.User_Id, cascadeDelete: true)
                .ForeignKey("dbo.InfoBooks", t => t.InfoBook_Id, cascadeDelete: true)
                .Index(t => t.User_Id)
                .Index(t => t.InfoBook_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UserInfoBooks", "InfoBook_Id", "dbo.InfoBooks");
            DropForeignKey("dbo.UserInfoBooks", "User_Id", "dbo.Users");
            DropIndex("dbo.UserInfoBooks", new[] { "InfoBook_Id" });
            DropIndex("dbo.UserInfoBooks", new[] { "User_Id" });
            DropTable("dbo.UserInfoBooks");
            DropTable("dbo.librarians");
            DropTable("dbo.Users");
            DropTable("dbo.InfoBooks");
        }
    }
}
