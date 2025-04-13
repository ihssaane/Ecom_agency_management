using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Commerce_Electronique.MODELS
{

    public abstract class Utilisateur
    {
        [Key]
        public int ID { get; set; }

        [Required, StringLength(50)]
        public string Nom { get; set; }

        [Required, StringLength(50)]
        public string Prenom { get; set; }

        [Required, StringLength(100)]
        public string Adresse { get; set; }

        [Required, StringLength(100)]
        public string Tel { get; set; }

       

        public string NomComplet => $"{Prenom} {Nom}";
    }


}
