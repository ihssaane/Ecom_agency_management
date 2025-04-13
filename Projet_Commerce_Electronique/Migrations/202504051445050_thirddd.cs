namespace Projet_Commerce_Electronique.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class thirddd : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Produits", "prix", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            DropColumn("dbo.Commandes", "Designation_commande");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Commandes", "Designation_commande", c => c.String());
            DropColumn("dbo.Produits", "prix");
        }
    }
}
