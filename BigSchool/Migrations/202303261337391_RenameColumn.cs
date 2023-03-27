﻿namespace BigSchool.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RenameColumn : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Courses", "IsCanceled", c => c.Boolean(nullable: false));
            DropColumn("dbo.Courses", "IsCanceld");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Courses", "IsCanceld", c => c.Boolean(nullable: false));
            DropColumn("dbo.Courses", "IsCanceled");
        }
    }
}
