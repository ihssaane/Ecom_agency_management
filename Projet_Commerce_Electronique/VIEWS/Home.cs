using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet_Commerce_Electronique.VIEWS
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void btn_clients_Click(object sender, EventArgs e)
        {
            this.Hide();
            GestionClients gestionClients = new GestionClients();  
            gestionClients.ShowDialog();  
            this.Show();
        }

        private void btn_produits_Click(object sender, EventArgs e)
        {
            this.Hide();
            GestionProduits gestionProduits = new GestionProduits();  
            gestionProduits.ShowDialog(); 
            this.Show();
        }

        private void btn_commandes_Click(object sender, EventArgs e)
        {
            this.Hide();
            GestionCommandes gestionCommandes = new GestionCommandes();
            gestionCommandes.ShowDialog();
            this.Show();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void btn_quitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.Hide();
            categories gestioncate = new categories();
            gestioncate.ShowDialog();
            this.Show();

        }
    }
}
