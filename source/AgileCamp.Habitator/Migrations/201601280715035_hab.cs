namespace AgileCamp.Habitator.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class hab : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Habits",
                c => new
                    {
                        HabitId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        Time = c.Time(nullable: false, precision: 7),
                    })
                .PrimaryKey(t => t.HabitId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Habits");
        }
    }
}
