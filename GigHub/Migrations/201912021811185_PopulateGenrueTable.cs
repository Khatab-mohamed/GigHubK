namespace GigHub.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateGenrueTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres(Id,Name) VALUES (1,'Jazz')");
            Sql("INSERT INTO Genres(Id,Name) VALUES (2,'Pop')");
            Sql("INSERT INTO Genres(Id,Name) VALUES (3,'Rock')");
            Sql("INSERT INTO Genres(Id,Name) VALUES (4,'Country')");
        }
        
        public override void Down()
        {
            Sql("DELETE FROM Genres Where Id IN (1,2,3,4)");
        }
    }
}
