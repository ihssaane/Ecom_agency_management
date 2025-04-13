namespace Projet_Commerce_Electronique.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class firstMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Utilisateurs",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Nom = c.String(nullable: false, maxLength: 50),
                        Prenom = c.String(nullable: false, maxLength: 50),
                        Adresse = c.String(nullable: false, maxLength: 100),
                        Tel = c.String(nullable: false, maxLength: 100),
                        Photo = c.String(),
                        Role = c.String(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        ID_categorie = c.Int(nullable: false, identity: true),
                        Nom_cat = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ID_categorie);
            
            CreateTable(
                "dbo.Produits",
                c => new
                    {
                        Id_produit = c.Int(nullable: false, identity: true),
                        Designation_produit = c.String(nullable: false),
                        Image_produit = c.String(),
                        ID_categorie = c.Int(nullable: false),
                        Qtestock = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id_produit)
                .ForeignKey("dbo.Categories", t => t.ID_categorie, cascadeDelete: true)
                .Index(t => t.ID_categorie);
            
            CreateTable(
                "dbo.Commandes",
                c => new
                    {
                        ID_commande = c.Int(nullable: false, identity: true),
                        Date_commande = c.DateTime(nullable: false),
                        Designation_commande = c.String(),
                        ID_client = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID_commande)
                .ForeignKey("dbo.Utilisateurs", t => t.ID_client, cascadeDelete: true)
                .Index(t => t.ID_client);
            
            CreateTable(
                "dbo.Lignes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ID_commande = c.Int(nullable: false),
                        ID_produit = c.Int(nullable: false),
                        Qte = c.Int(nullable: false),
                        Prix = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Commandes", t => t.ID_commande, cascadeDelete: true)
                .ForeignKey("dbo.Produits", t => t.ID_produit, cascadeDelete: true)
                .Index(t => t.ID_commande)
                .Index(t => t.ID_produit);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Lignes", "ID_produit", "dbo.Produits");
            DropForeignKey("dbo.Lignes", "ID_commande", "dbo.Commandes");
            DropForeignKey("dbo.Commandes", "ID_client", "dbo.Utilisateurs");
            DropForeignKey("dbo.Produits", "ID_categorie", "dbo.Categories");
            DropIndex("dbo.Lignes", new[] { "ID_produit" });
            DropIndex("dbo.Lignes", new[] { "ID_commande" });
            DropIndex("dbo.Commandes", new[] { "ID_client" });
            DropIndex("dbo.Produits", new[] { "ID_categorie" });
            DropTable("dbo.Lignes");
            DropTable("dbo.Commandes");
            DropTable("dbo.Produits");
            DropTable("dbo.Categories");
            DropTable("dbo.Utilisateurs");
        }
    }
}
