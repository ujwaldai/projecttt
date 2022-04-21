namespace DMS.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class tablename : DbMigration
    {
        public override void Up()
        {
            Sql(@"Create table helo( 
                id int primary key (1,1),
                name varchar(20),
                address varchar(20)                
)");


        }


        public override void Down()
        {
        }
    }
}

