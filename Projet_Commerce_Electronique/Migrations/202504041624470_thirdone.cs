namespace Projet_Commerce_Electronique.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class thirdone : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Utilisateurs", "Photo");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Utilisateurs", "Photo", c => c.String());
        }
    }
}
