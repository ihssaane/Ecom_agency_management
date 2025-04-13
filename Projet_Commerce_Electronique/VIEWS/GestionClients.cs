using Projet_Commerce_Electronique.CONTROLLERS;
using Projet_Commerce_Electronique.INTERFACES;
using Projet_Commerce_Electronique.MODELS;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Projet_Commerce_Electronique.VIEWS
{
    public partial class GestionClients : Form
    {
        private ClientController controller;

        public GestionClients()
        {
            InitializeComponent();
            controller = new ClientController(new ClientRepository());
        }

        private void GestionClients_Load(object sender, EventArgs e)
        {
            ChargerClients();

            dataGridView_clients.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView_clients.MultiSelect = false;
            dataGridView_clients.CellClick += dataGridView_clients_CellClick;
        }

        private void ChargerClients()
        {
            try
            {
                List<Client> clients = controller.GetAllClients();
                dataGridView_clients.DataSource = null;
                dataGridView_clients.DataSource = clients;

                if (dataGridView_clients.Columns.Count > 0)
                {
                    dataGridView_clients.Columns["Id"].HeaderText = "ID";
                    dataGridView_clients.Columns["Nom"].HeaderText = "Nom";
                    dataGridView_clients.Columns["Prenom"].HeaderText = "Prénom";
                    dataGridView_clients.Columns["Adresse"].HeaderText = "Adresse";
                    dataGridView_clients.Columns["Tel"].HeaderText = "Téléphone";

                    dataGridView_clients.Columns["Id"].Width = 50;
                    dataGridView_clients.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du chargement des clients : " + ex.Message,
                                "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView_clients_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    DataGridViewRow row = dataGridView_clients.Rows[e.RowIndex];
                    int clientId = Convert.ToInt32(row.Cells["Id"].Value);

                    Client client = controller.GetClientById(clientId);
                    if (client != null)
                    {
                        txt_id_client.Text = client.ID.ToString();
                        txt_nom_client.Text = client.Nom;
                        txt_prenom_client.Text = client.Prenom;
                        txt_adresse.Text = client.Adresse;
                        txt_telephone.Text = client.Tel;
                    }
                    else
                    {
                        MessageBox.Show("Ce client n'existe plus dans la base de données.",
                                        "Client introuvable", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur lors du chargement des détails du client : " + ex.Message,
                                    "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_ajouter_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txt_nom_client.Text) ||
                    string.IsNullOrWhiteSpace(txt_prenom_client.Text))
                {
                    MessageBox.Show("Veuillez remplir au moins le nom et le prénom du client.",
                                    "Champs obligatoires", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Client nouveauClient = new Client
                {
                    Nom = txt_nom_client.Text.Trim(),
                    Prenom = txt_prenom_client.Text.Trim(),
                    Adresse = txt_adresse.Text.Trim(),
                    Tel = txt_telephone.Text.Trim()
                };

                controller.AjouterClient(nouveauClient);
                MessageBox.Show("Client ajouté avec succès !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ViderChamps();
                ChargerClients();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_modifier_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(txt_id_client.Text, out int clientId))
                {
                    MessageBox.Show("Veuillez sélectionner un client à modifier.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Client clientExistant = controller.GetClientById(clientId);
                if (clientExistant == null)
                {
                    MessageBox.Show("Client introuvable.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                clientExistant.Nom = txt_nom_client.Text.Trim();
                clientExistant.Prenom = txt_prenom_client.Text.Trim();
                clientExistant.Adresse = txt_adresse.Text.Trim();
                clientExistant.Tel = txt_telephone.Text.Trim();

                controller.UpdateClient(clientExistant);
                MessageBox.Show("Client modifié avec succès !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ViderChamps();
                ChargerClients();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_supprimer_Click(object sender, EventArgs e)
        {
            try
            { 
                //pour convertir si il y a une chaine de caractère
                if (!int.TryParse(txt_id_client.Text, out int clientId))
                {
                    MessageBox.Show("Veuillez sélectionner un client à supprimer.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Client clientASupprimer = controller.GetClientById(clientId);
                if (clientASupprimer == null)
                {
                    MessageBox.Show("Client introuvable.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var confirmation = MessageBox.Show(
                    $"Voulez-vous vraiment supprimer le client {clientASupprimer.Prenom} {clientASupprimer.Nom} ?",
                    "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirmation == DialogResult.Yes)
                {
                    controller.DeleteClient(clientId);
                    MessageBox.Show("Client supprimé avec succès !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ViderChamps();
                    ChargerClients();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ViderChamps()
        {
            txt_id_client.Clear();
            txt_nom_client.Clear();
            txt_prenom_client.Clear();
            txt_adresse.Clear();
            txt_telephone.Clear();
        }

        private void txt_id_client_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btn_retour_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
