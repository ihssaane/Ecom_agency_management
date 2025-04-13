using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Projet_Commerce_Electronique.MODELS;

namespace Projet_Commerce_Electronique.VIEWS
{
    public partial class GestionCommandes : Form
    {
        private readonly CommerceDbContext db;
        private List<Ligne> lignesCommande;
        private decimal totalCommande = 0;
        private Client clientSelectionne;

        public GestionCommandes()
        {
            InitializeComponent();

            
            db = new CommerceDbContext();

            
            lignesCommande = new List<Ligne>();

            
            ChargerClients();
            ChargerProduits();

            
            ConfigurerDataGridViewPanier();

            
            ActivationControlsCommande(false);

            
            lblDateCommande.Text = $"Date: {DateTime.Now.ToString("dd/MM/yyyy")}";
        }

        private void ConfigurerDataGridViewPanier()
        {
            
            dgvPanier.AutoGenerateColumns = false;

           
            DataGridViewTextBoxColumn colIdProduit = new DataGridViewTextBoxColumn();
            colIdProduit.DataPropertyName = "ID_produit";
            colIdProduit.HeaderText = "ID";
            colIdProduit.Width = 40;
            dgvPanier.Columns.Add(colIdProduit);

           
            DataGridViewTextBoxColumn colNomProduit = new DataGridViewTextBoxColumn();
            colNomProduit.HeaderText = "Produit";
            colNomProduit.Width = 150;
            dgvPanier.Columns.Add(colNomProduit);

            
            DataGridViewTextBoxColumn colQuantite = new DataGridViewTextBoxColumn();
            colQuantite.DataPropertyName = "Qte";
            colQuantite.HeaderText = "Quantité";
            colQuantite.Width = 70;
            dgvPanier.Columns.Add(colQuantite);

            
            DataGridViewTextBoxColumn colPrix = new DataGridViewTextBoxColumn();
            colPrix.DataPropertyName = "Prix";
            colPrix.HeaderText = "Prix unitaire";
            colPrix.Width = 90;
            colPrix.DefaultCellStyle.Format = "N2";
            dgvPanier.Columns.Add(colPrix);

            
            DataGridViewTextBoxColumn colTotal = new DataGridViewTextBoxColumn();
            colTotal.HeaderText = "Total";
            colTotal.Width = 90;
            colTotal.DefaultCellStyle.Format = "N2";
            dgvPanier.Columns.Add(colTotal);

           
            DataGridViewButtonColumn colSupprimer = new DataGridViewButtonColumn();
            colSupprimer.HeaderText = "Action";
            colSupprimer.Text = "Supprimer";
            colSupprimer.UseColumnTextForButtonValue = true;
            colSupprimer.Width = 80;
            dgvPanier.Columns.Add(colSupprimer);
        }

        private void ChargerClients()
        {
            try
            {
                var clients = db.Clients.ToList();
                cmbClients.DataSource = clients;
                cmbClients.DisplayMember = "Nom"; 
                cmbClients.ValueMember = "ID";
                cmbClients.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors du chargement des clients : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ChargerProduits()
        {
            try
            {
                var produits = db.Produits.ToList();
                cmbProduits.DataSource = produits;
                cmbProduits.DisplayMember = "Designation_produit";
                cmbProduits.ValueMember = "Id_produit";
                cmbProduits.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors du chargement des produits : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ActivationControlsCommande(bool activer)
        {
           
            groupBoxProduits.Enabled = activer;
            btnValiderCommande.Enabled = activer;
            btnAnnulerCommande.Enabled = activer;
        }

        private void cmbClients_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbClients.SelectedItem != null)
            {
                clientSelectionne = (Client)cmbClients.SelectedItem;
                lblClientSelectionne.Text = $"Client: {clientSelectionne.Nom} {clientSelectionne.Prenom}";

                
                ActivationControlsCommande(true);

               
                ChargerCommandesClient(clientSelectionne.ID);
            }
            else
            {
                clientSelectionne = null;
                lblClientSelectionne.Text = "Aucun client sélectionné";
                ActivationControlsCommande(false);
            }
        }

        private void ChargerCommandesClient(int idClient)
        {
            try
            {
                var commandes = db.Commandes
                    .Include(c => c.Client)
                    .Where(c => c.ID_client == idClient)
                    .ToList();

                dgvCommandesPrecedentes.DataSource = commandes;

               
                if (dgvCommandesPrecedentes.Columns.Contains("Client"))
                    dgvCommandesPrecedentes.Columns["Client"].Visible = false;

                if (dgvCommandesPrecedentes.Columns.Contains("Lignes"))
                    dgvCommandesPrecedentes.Columns["Lignes"].Visible = false;

              
                if (dgvCommandesPrecedentes.Columns.Contains("Date_commande"))
                    dgvCommandesPrecedentes.Columns["Date_commande"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors du chargement des commandes : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAjouterAuPanier_Click(object sender, EventArgs e)
        {
            if (cmbProduits.SelectedItem == null)
            {
                MessageBox.Show("Veuillez sélectionner un produit.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int quantite;
            if (!int.TryParse(txtQuantite.Text, out quantite) || quantite <= 0)
            {
                MessageBox.Show("Veuillez entrer une quantité valide.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Produit produitSelectionne = (Produit)cmbProduits.SelectedItem;

           
            if (produitSelectionne.Qtestock < quantite)
            {
                MessageBox.Show($"Stock insuffisant. Quantité disponible : {produitSelectionne.Qtestock}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            
            Ligne ligneExistante = lignesCommande.FirstOrDefault(l => l.ID_produit == produitSelectionne.Id_produit);

            if (ligneExistante != null)
            {
               
                if (produitSelectionne.Qtestock < ligneExistante.Qte + quantite)
                {
                    MessageBox.Show($"Stock insuffisant. Quantité disponible : {produitSelectionne.Qtestock}, Quantité déjà dans le panier : {ligneExistante.Qte}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                
                ligneExistante.Qte += quantite;
                MessageBox.Show("Quantité mise à jour dans le panier.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                
                decimal prix = produitSelectionne.prix;

                
                Ligne nouvelleLigne = new Ligne
                {
                    ID_produit = produitSelectionne.Id_produit,
                    Produit = produitSelectionne,
                    Qte = quantite,
                    Prix = prix
                };

                lignesCommande.Add(nouvelleLigne);
                MessageBox.Show("Produit ajouté au panier.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            
            RafraichirAffichagePanier();

           
            cmbProduits.SelectedIndex = -1;
            txtQuantite.Text = "1";
        }

        private void RafraichirAffichagePanier()
        {
            
            dgvPanier.Rows.Clear();

           
            totalCommande = 0;

           
            foreach (var ligne in lignesCommande)
            {
                decimal totalLigne = ligne.Prix * ligne.Qte;
                totalCommande += totalLigne;

                int rowIndex = dgvPanier.Rows.Add();
                DataGridViewRow row = dgvPanier.Rows[rowIndex];

                row.Cells[0].Value = ligne.ID_produit;
                row.Cells[1].Value = ligne.Produit.Designation_produit;
                row.Cells[2].Value = ligne.Qte;
                row.Cells[3].Value = ligne.Prix;
                row.Cells[4].Value = totalLigne;
            }

            
            lblTotal.Text = $"Total: {totalCommande:C2}";
        }

        private void dgvPanier_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (e.RowIndex >= 0 && e.ColumnIndex == 5) 
            {
                int idProduit = Convert.ToInt32(dgvPanier.Rows[e.RowIndex].Cells[0].Value);
                Ligne ligneASupprimer = lignesCommande.FirstOrDefault(l => l.ID_produit == idProduit);

                if (ligneASupprimer != null)
                {
                    lignesCommande.Remove(ligneASupprimer);
                    RafraichirAffichagePanier();
                }
            }
        }

        private void btnValiderCommande_Click(object sender, EventArgs e)
        {
            if (lignesCommande.Count == 0)
            {
                MessageBox.Show("Le panier est vide. Veuillez ajouter des produits avant de valider la commande.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                using (var transaction = db.Database.BeginTransaction())
                {
                    try
                    {
                        
                        Commande nouvelleCommande = new Commande
                        {
                            Date_commande = DateTime.Now,
                            ID_client = clientSelectionne.ID,
                            Lignes = new List<Ligne>()
                        };

                        
                        db.Commandes.Add(nouvelleCommande);
                        db.SaveChanges();

                        
                        foreach (var ligne in lignesCommande)
                        {
                            ligne.ID_commande = nouvelleCommande.ID_commande;
                            db.Lignes.Add(ligne);

                           
                            var produit = db.Produits.Find(ligne.ID_produit);
                            if (produit != null)
                            {
                                produit.Qtestock -= ligne.Qte;
                                if (produit.Qtestock < 0)
                                {
                                    throw new Exception($"Stock insuffisant pour le produit {produit.Designation_produit}");
                                }
                            }
                        }

                        
                        db.SaveChanges();
                        transaction.Commit();

                        MessageBox.Show($"Commande enregistrée avec succès pour le client {clientSelectionne.Nom}.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        
                        ChargerCommandesClient(clientSelectionne.ID);

                        
                        lignesCommande.Clear();
                        RafraichirAffichagePanier();
                    }
                    catch (Exception ex)
                    {
                        
                        transaction.Rollback();
                        throw new Exception("Erreur lors de l'enregistrement de la commande : " + ex.Message);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAnnulerCommande_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Êtes-vous sûr de vouloir annuler cette commande ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                lignesCommande.Clear();
                RafraichirAffichagePanier();
                MessageBox.Show("La commande a été annulée.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgvCommandesPrecedentes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    int idCommande = Convert.ToInt32(dgvCommandesPrecedentes.Rows[e.RowIndex].Cells["ID_commande"].Value);
                    AfficherDetailsCommande(idCommande);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erreur lors de la sélection de la commande : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void AfficherDetailsCommande(int idCommande)
        {
            try
            {
                var detailsCommande = db.Lignes
                    .Include(l => l.Produit)
                    .Where(l => l.ID_commande == idCommande)
                    .ToList();

               
                var detailsFormattés = detailsCommande.Select(l => new {
                    ID_produit = l.ID_produit,
                    Produit = l.Produit.Designation_produit,
                    Quantité = l.Qte,
                    Prix_unitaire = l.Prix,
                    Total = l.Prix * l.Qte
                }).ToList();

                dgvDetailsCommande.DataSource = detailsFormattés;

                
                decimal totalCmd = detailsCommande.Sum(l => l.Prix * l.Qte);
                lblTotalDetails.Text = $"Total de la commande: {totalCmd:C2}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors du chargement des détails de la commande : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            db.Dispose();
        }

        private void GestionCommandes_Load(object sender, EventArgs e)
        {

        }
    }
}