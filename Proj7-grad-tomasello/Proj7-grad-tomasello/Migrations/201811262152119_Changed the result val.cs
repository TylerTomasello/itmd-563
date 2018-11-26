namespace Proj7_grad_tomasello.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Changedtheresultval : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.CalcMortgages", "Result", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.CalcMortgages", "Result", c => c.Double(nullable: false));
        }
    }
}
