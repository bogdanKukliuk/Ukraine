namespace Context.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dodik : DbMigration
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
                "dbo.librarians",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Name = c.String(nullable: false, maxLength: 228),
                        Post = c.String(nullable: false, maxLength: 228),
                        Debtors = c.String(nullable: false, maxLength: 228),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.Id)
                .Index(t => t.Id);
            
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
                "dbo.librarianInfoBooks",
                c => new
                    {
                        librarian_Id = c.Int(nullable: false),
                        InfoBook_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.librarian_Id, t.InfoBook_Id })
                .ForeignKey("dbo.librarians", t => t.librarian_Id, cascadeDelete: true)
                .ForeignKey("dbo.InfoBooks", t => t.InfoBook_Id, cascadeDelete: true)
                .Index(t => t.librarian_Id)
                .Index(t => t.InfoBook_Id);
            
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
            DropForeignKey("dbo.librarians", "Id", "dbo.Users");
            DropForeignKey("dbo.UserInfoBooks", "InfoBook_Id", "dbo.InfoBooks");
            DropForeignKey("dbo.UserInfoBooks", "User_Id", "dbo.Users");
            DropForeignKey("dbo.librarianInfoBooks", "InfoBook_Id", "dbo.InfoBooks");
            DropForeignKey("dbo.librarianInfoBooks", "librarian_Id", "dbo.librarians");
            DropIndex("dbo.UserInfoBooks", new[] { "InfoBook_Id" });
            DropIndex("dbo.UserInfoBooks", new[] { "User_Id" });
            DropIndex("dbo.librarianInfoBooks", new[] { "InfoBook_Id" });
            DropIndex("dbo.librarianInfoBooks", new[] { "librarian_Id" });
            DropIndex("dbo.librarians", new[] { "Id" });
            DropTable("dbo.UserInfoBooks");
            DropTable("dbo.librarianInfoBooks");
            DropTable("dbo.Users");
            DropTable("dbo.librarians");
            DropTable("dbo.InfoBooks");
        }
    }
}
