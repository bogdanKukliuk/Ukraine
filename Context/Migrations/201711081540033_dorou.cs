namespace Context.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dorou : DbMigration
    {
        public override void Up()
        {
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
            
        }
        
        public override void Down()
        {
            DropTable("dbo.librarians");
        }
    }
}
