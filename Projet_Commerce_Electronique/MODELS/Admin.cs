using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Commerce_Electronique.MODELS
{
    public class Admin : Utilisateur
    {
        public string Role { get; set; } = "Admin";
    }

}
