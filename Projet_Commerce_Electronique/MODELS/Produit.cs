using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Commerce_Electronique.MODELS
{
    public class Produit
    {
        [Key]
        public int Id_produit { get; set; }

        [Required]
        public string Designation_produit { get; set; }

        public string Image_produit { get; set; }

        [Required]
        [ForeignKey("Categorie")]

        public int ID_categorie { get; set; }

        public int Qtestock { get; set; }

        public Decimal prix { get; set; }

        public virtual Categorie Categorie { get; set; }
    }

}
