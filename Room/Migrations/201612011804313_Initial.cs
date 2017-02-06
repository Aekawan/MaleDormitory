namespace Room.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Roomadds",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        RoomNo = c.String(),
                        Roomtype = c.String(),
                        Price = c.String(),
                        Status = c.String(),
                        StudentID = c.String(),
                        StudentID2 = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        StudentID = c.String(),
                        Fname = c.String(),
                        Lname = c.String(),
                        RoomNo = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Students");
            DropTable("dbo.Roomadds");
        }
    }
}
