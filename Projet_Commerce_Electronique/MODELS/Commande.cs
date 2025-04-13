using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.LinkLabel;

namespace Projet_Commerce_Electronique.MODELS
{
    public class Commande
    {
        [Key]
        public int ID_commande { get; set; }

        public DateTime Date_commande { get; set; }

      

        [ForeignKey("Client")]
        public int ID_client { get; set; }

        public virtual Client Client { get; set; }

        public virtual ICollection<Ligne> Lignes { get; set; }
    }

}
