using System.Collections.Generic;

namespace Projet_Commerce_Electronique.MODELS
{
    public class Client : Utilisateur
    {
        public virtual ICollection<Commande> Commandes { get; set; }
    }

}