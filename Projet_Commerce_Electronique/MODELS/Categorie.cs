using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Projet_Commerce_Electronique.MODELS
{
    public class Categorie
    {
        [Key]
        public int ID_categorie { get; set; }

        [Required]
        public string Nom_cat { get; set; }

        public virtual ICollection<Produit> Produits { get; set; }
    }

}