using Clinique_CF.INTERFACES;
using Clinique_CF.REPOSITORY;
using Projet_Commerce_Electronique.CONTROLLERS;
using Projet_Commerce_Electronique.INTERFACES;
using Projet_Commerce_Electronique.MODELS;
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
    public partial class categories : Form
    {
        private CategorieController controller;

        public categories()
        {
            InitializeComponent();
            controller = new CategorieController(new CategorieRepository());
        }

        private void ChargerCategories()
        {
            try
            {
                
                List<Categorie> listeCategories = controller.GetAllCategories();

                
                dataGridView_categories.DataSource = null; 
                dataGridView_categories.DataSource = listeCategories; 

                
                if (dataGridView_categories.Columns.Count > 0)
                {
                    try
                    {
                       

                        if (dataGridView_categories.Columns.Contains("ID_categorie"))
                        {
                            dataGridView_categories.Columns["ID_categorie"].HeaderText = "ID";
                            dataGridView_categories.Columns["ID_categorie"].Width = 50;
                        }

                       
                        if (dataGridView_categories.Columns.Contains("Nom_cat"))
                        {
                            dataGridView_categories.Columns["Nom_cat"].HeaderText = "Nom de la catégorie";
                            dataGridView_categories.Columns["Nom_cat"].Width = 200;
                        }

                        dataGridView_categories.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                    }
                    catch (Exception ex)
                    {
                       
                        System.Diagnostics.Debug.WriteLine("Erreur de configuration des colonnes: " + ex.Message);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du chargement des catégories : " + ex.Message,
                    "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ViderChamps()
        {
            id_cattt.Clear();
            nom_catt.Clear();
            id_cattt.Focus();
        }

        private void categories_Load(object sender, EventArgs e)
        {
            
            ChargerCategories();

           
            dataGridView_categories.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView_categories.MultiSelect = false;
        }

        private void btn_ajouter_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nom_catt.Text))
            {
                MessageBox.Show("Veuillez remplir le nom de la catégorie.", "Champ obligatoire", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                
                var categorie = new Categorie
                {
                    Nom_cat = nom_catt.Text
                };

                
                if (!string.IsNullOrWhiteSpace(id_cattt.Text))
                {
                    if (!int.TryParse(id_cattt.Text, out int id))
                    {
                        MessageBox.Show("L'ID doit être un nombre entier.", "Erreur de format", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    categorie.ID_categorie = id;
                }

                controller.AjouterCategorie(categorie);

                MessageBox.Show("Catégorie ajoutée avec succès !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ViderChamps();
                ChargerCategories();
            }
            catch (FormatException)
            {
                MessageBox.Show("L'ID doit être un nombre entier valide.", "Erreur de format", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de l'ajout : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_modifier_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(id_cattt.Text))
            {
                MessageBox.Show("Veuillez sélectionner une catégorie à modifier.",
                    "Sélection requise", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(nom_catt.Text))
            {
                MessageBox.Show("Le nom de la catégorie ne peut pas être vide.",
                    "Champ obligatoire", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (!int.TryParse(id_cattt.Text, out int id))
                {
                    MessageBox.Show("L'ID doit être un nombre entier.",
                        "Erreur de format", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

               
                Categorie categorieExistante = controller.GetCategorieById(id);
                if (categorieExistante == null)
                {
                    MessageBox.Show("Catégorie introuvable.",
                        "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

               
                categorieExistante.Nom_cat = nom_catt.Text;

                
                controller.UpdateCategorie(categorieExistante);

               
                MessageBox.Show("Catégorie modifiée avec succès !",
                    "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);

              
                ViderChamps();
                ChargerCategories();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la modification : " + ex.Message,
                    "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_supprimer_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(id_cattt.Text))
            {
                MessageBox.Show("Veuillez sélectionner une catégorie à supprimer.",
                    "Sélection requise", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (!int.TryParse(id_cattt.Text, out int id))
                {
                    MessageBox.Show("L'ID doit être un nombre entier.",
                        "Erreur de format", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

               
                Categorie categorie = controller.GetCategorieById(id);
                if (categorie == null)
                {
                    MessageBox.Show("Catégorie introuvable.",
                        "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

              
                var confirmation = MessageBox.Show(
                    $"Voulez-vous vraiment supprimer la catégorie '{categorie.Nom_cat}' ?\n\nAttention : Cela pourrait affecter les produits associés à cette catégorie.",
                    "Confirmation de suppression",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (confirmation == DialogResult.Yes)
                {
                    
                    controller.DeleteCategorie(categorie);

                   
                    MessageBox.Show("Catégorie supprimée avec succès !",
                        "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);

                   
                    ViderChamps();
                    ChargerCategories();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la suppression : " + ex.Message,
                    "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView_categories_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                  
                    DataGridViewRow row = dataGridView_categories.Rows[e.RowIndex];

                   
                    int categorieId;

                    
                    if (dataGridView_categories.Columns.Contains("ID_categorie"))
                    {
                        categorieId = Convert.ToInt32(row.Cells["ID_categorie"].Value);
                    }
                    else
                    {
                        
                        categorieId = Convert.ToInt32(row.Cells[0].Value);
                    }

                    
                    Categorie categorie = controller.GetCategorieById(categorieId);

                    if (categorie != null)
                    {
                       
                        id_cattt.Text = categorie.ID_categorie.ToString();
                        nom_catt.Text = categorie.Nom_cat;
                    }
                    else
                    {
                        MessageBox.Show("Cette catégorie n'existe plus dans la base de données.",
                            "Catégorie introuvable", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur lors du chargement des détails de la catégorie : " + ex.Message,
                        "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_retour_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
          
        }
    }
}