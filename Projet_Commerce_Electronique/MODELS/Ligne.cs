using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Projet_Commerce_Electronique.MODELS
{
    public class Ligne
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("Commande")]
        public int ID_commande { get; set; }

        [ForeignKey("Produit")]
        public int ID_produit { get; set; }

        public int Qte { get; set; }

        public decimal Prix { get; set; }

        public virtual Commande Commande { get; set; }
        public virtual Produit Produit { get; set; }
    }

}