using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Projet_Commerce_Electronique.CONTROLLERS;
using Projet_Commerce_Electronique.INTERFACES;
using Projet_Commerce_Electronique.MODELS;

namespace Projet_Commerce_Electronique.VIEWS
{
    public partial class GestionProduits : Form
    {
        private string imagePath = "";
        private bool isModifying = false;
        private ProduitController produitController;
        private readonly CategorieRepository categorieRepository = new CategorieRepository();

        public GestionProduits()
        {
            try
            {
                InitializeComponent();
                produitController = new ProduitController();
                LoadCategories();
                dataGridView_produits.DataSource = produitController.GetAllProduits();

               
                if (dataGridView_produits.Columns.Contains("prix"))
                {
                    dataGridView_produits.Columns["prix"].DefaultCellStyle.Format = "N2"; 
                    dataGridView_produits.Columns["prix"].HeaderText = "Prix (DH)";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de l'initialisation : {ex.Message}\n\nStack Trace: {ex.StackTrace}", "Erreur critique", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadCategories()
        {
            try
            {
                var categories = categorieRepository.GetAll().ToList();
                comboBox_catego.DataSource = categories;
                comboBox_catego.DisplayMember = "Nom_cat";
                comboBox_catego.ValueMember = "ID_categorie";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du chargement des catégories : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label1_Click(object sender, EventArgs e) { }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void GestionProduits_Load(object sender, EventArgs e) { }

        private void btn_ajouter_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txt_id_produit.Text))
                {
                    MessageBox.Show("Veuillez saisir l'ID du produit.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_id_produit.Focus();
                    return;
                }

                if (!int.TryParse(txt_id_produit.Text, out int id))
                {
                    MessageBox.Show("L'ID du produit doit être un nombre entier.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_id_produit.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(txt_designation_produit.Text))
                {
                    MessageBox.Show("Veuillez saisir la désignation du produit.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_designation_produit.Focus();
                    return;
                }

                int quantite;
                if (!int.TryParse(num_qte_stock.Text, out quantite))
                {
                    MessageBox.Show("Veuillez saisir une quantité valide.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    num_qte_stock.Focus();
                    return;
                }

               
                decimal prix;
                if (!decimal.TryParse(price.Text, out prix))
                {
                    MessageBox.Show("Veuillez saisir un prix valide.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    price.Focus();
                    return;
                }

                if (comboBox_catego.SelectedValue == null)
                {
                    MessageBox.Show("Veuillez sélectionner une catégorie.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    comboBox_catego.Focus();
                    return;
                }

                string imageFileName = "";
                string destinationPath = "";

                if (!string.IsNullOrEmpty(imagePath))
                {
                    imageFileName = DateTime.Now.Ticks.ToString() + Path.GetExtension(imagePath);
                    destinationPath = Path.Combine(Application.StartupPath, "Images", imageFileName);
                    Directory.CreateDirectory(Path.Combine(Application.StartupPath, "Images"));
                    File.Copy(imagePath, destinationPath, true);
                }
                else if (isModifying)
                {
                    var existingProduct = produitController.GetProduitById(id);
                    if (existingProduct != null)
                    {
                        imageFileName = existingProduct.Image_produit;
                    }
                }
                else
                {
                    MessageBox.Show("Veuillez sélectionner une image pour le produit.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var produit = new Produit
                {
                    Id_produit = id,
                    Designation_produit = txt_designation_produit.Text.Trim(),
                    ID_categorie = Convert.ToInt32(comboBox_catego.SelectedValue),
                    Qtestock = quantite,
                    Image_produit = imageFileName,
                    prix = prix  
                };

                try
                {
                    if (isModifying)
                    {
                        produitController.UpdateProduit(produit);
                        MessageBox.Show("Produit modifié avec succès!", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        isModifying = false;
                        txt_id_produit.Enabled = true;
                    }
                    else
                    {
                        produitController.AjouterProduit(produit);
                        MessageBox.Show("Produit ajouté avec succès!", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    ClearFields();
                    RefreshDataGrid();
                }
                catch (Exception ex)
                {
                    if (!string.IsNullOrEmpty(destinationPath) && File.Exists(destinationPath) && !isModifying)
                    {
                        File.Delete(destinationPath);
                    }
                    throw new Exception("Erreur lors de l'ajout du produit: " + ex.Message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Une erreur s'est produite : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearFields()
        {
            txt_id_produit.Text = "";
            txt_designation_produit.Text = "";
            num_qte_stock.Text = "0";
            price.Text = "0"; 
            comboBox_catego.SelectedIndex = -1;

            if (pic_image_produit.Image != null)
            {
                pic_image_produit.Image.Dispose();
                pic_image_produit.Image = null;
            }

            imagePath = "";
        }

        private void RefreshDataGrid()
        {
            try
            {
                var produits = produitController.GetAllProduits();
                dataGridView_produits.DataSource = null;
                dataGridView_produits.DataSource = produits;

                
                if (dataGridView_produits.Columns.Contains("prix"))
                {
                    dataGridView_produits.Columns["prix"].DefaultCellStyle.Format = "N2"; 
                    dataGridView_produits.Columns["prix"].HeaderText = "Prix (€)";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors du chargement des données : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_parcourir_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.Filter = "Fichiers images|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
                    openFileDialog.Title = "Sélectionner une image";
                    openFileDialog.Multiselect = false;
                    openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);

                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        imagePath = openFileDialog.FileName;

                        if (pic_image_produit.Image != null)
                        {
                            pic_image_produit.Image.Dispose();
                            pic_image_produit.Image = null;
                        }

                        using (var stream = new FileStream(imagePath, FileMode.Open, FileAccess.Read))
                        {
                            pic_image_produit.Image = Image.FromStream(stream);
                            pic_image_produit.SizeMode = PictureBoxSizeMode.Zoom;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors du chargement de l'image : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                imagePath = "";
                if (pic_image_produit.Image != null)
                {
                    pic_image_produit.Image.Dispose();
                    pic_image_produit.Image = null;
                }
            }
        }

        private void btn_modifier_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView_produits.CurrentRow != null)
                {
                    isModifying = true;

                    var produit = (Produit)dataGridView_produits.CurrentRow.DataBoundItem;

                    txt_id_produit.Text = produit.Id_produit.ToString();
                    txt_id_produit.Enabled = false;
                    txt_designation_produit.Text = produit.Designation_produit;
                    num_qte_stock.Text = produit.Qtestock.ToString();

                    
                    price.Text = produit.prix.ToString();

                    foreach (var item in comboBox_catego.Items)
                    {
                        dynamic category = item;
                        if (category.ID_categorie == produit.ID_categorie)
                        {
                            comboBox_catego.SelectedItem = item;
                            break;
                        }
                    }

                    string imagePath = Path.Combine(Application.StartupPath, "Images", produit.Image_produit);
                    if (File.Exists(imagePath))
                    {
                        if (pic_image_produit.Image != null)
                        {
                            pic_image_produit.Image.Dispose();
                            pic_image_produit.Image = null;
                        }

                        using (var stream = new FileStream(imagePath, FileMode.Open, FileAccess.Read))
                        {
                            pic_image_produit.Image = Image.FromStream(stream);
                            pic_image_produit.SizeMode = PictureBoxSizeMode.Zoom;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Veuillez sélectionner un produit à modifier.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de la préparation à la modification : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView_produits_CellContentClick(object sender, DataGridViewCellEventArgs e) { }

        private void btn_retour_Click(object sender, EventArgs e) {
            this.Close();
        }
        private void txt_id_produit_TextChanged(object sender, EventArgs e) { }
        private void txt_designation_produit_TextChanged(object sender, EventArgs e) { }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) { }

        private void btn_supprimer_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView_produits.CurrentRow != null)
                {
                    var produit = (Produit)dataGridView_produits.CurrentRow.DataBoundItem;

                    DialogResult result = MessageBox.Show(
                        $"Êtes-vous sûr de vouloir supprimer le produit '{produit.Designation_produit}' ?",
                        "Confirmer la suppression",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        if (!string.IsNullOrEmpty(produit.Image_produit))
                        {
                            string imagePath = Path.Combine(Application.StartupPath, "Images", produit.Image_produit);
                            if (File.Exists(imagePath))
                            {
                                try
                                {
                                    File.Delete(imagePath);
                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine($"Erreur lors de la suppression de l'image: {ex.Message}");
                                }
                            }
                        }

                        produitController.DeleteProduit(produit);
                        MessageBox.Show("Produit supprimé avec succès!", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        RefreshDataGrid();
                    }
                }
                else
                {
                    MessageBox.Show("Veuillez sélectionner un produit à supprimer.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de la suppression du produit : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label7_Click(object sender, EventArgs e) { }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e) { }
    }
}