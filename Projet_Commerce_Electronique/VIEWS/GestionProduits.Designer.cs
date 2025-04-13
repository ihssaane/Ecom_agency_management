namespace Projet_Commerce_Electronique.VIEWS
{
    partial class GestionProduits
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_retour = new System.Windows.Forms.Button();
            this.groupBoxInfoProduit = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.prix = new System.Windows.Forms.Label();
            this.txt_id_produit = new System.Windows.Forms.TextBox();
            this.txt_designation_produit = new System.Windows.Forms.TextBox();
            this.num_qte_stock = new System.Windows.Forms.TextBox();
            this.price = new System.Windows.Forms.TextBox();
            this.comboBox_catego = new System.Windows.Forms.ComboBox();
            this.pic_image_produit = new System.Windows.Forms.PictureBox();
            this.btn_parcourir = new System.Windows.Forms.Button();
            this.groupBoxActions = new System.Windows.Forms.GroupBox();
            this.btn_ajouter = new System.Windows.Forms.Button();
            this.btn_modifier = new System.Windows.Forms.Button();
            this.btn_supprimer = new System.Windows.Forms.Button();
            this.groupBoxListeProduits = new System.Windows.Forms.GroupBox();
            this.dataGridView_produits = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panel1.SuspendLayout();
            this.groupBoxInfoProduit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_image_produit)).BeginInit();
            this.groupBoxActions.SuspendLayout();
            this.groupBoxListeProduits.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_produits)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_retour);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1099, 74);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(16, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(313, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gestion des Produits";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn_retour
            // 
            this.btn_retour.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_retour.BackColor = System.Drawing.Color.White;
            this.btn_retour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_retour.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_retour.Location = new System.Drawing.Point(968, 18);
            this.btn_retour.Margin = new System.Windows.Forms.Padding(4);
            this.btn_retour.Name = "btn_retour";
            this.btn_retour.Size = new System.Drawing.Size(115, 37);
            this.btn_retour.TabIndex = 15;
            this.btn_retour.Text = "Retour";
            this.btn_retour.UseVisualStyleBackColor = false;
            this.btn_retour.Click += new System.EventHandler(this.btn_retour_Click);
            // 
            // groupBoxInfoProduit
            // 
            this.groupBoxInfoProduit.Controls.Add(this.label2);
            this.groupBoxInfoProduit.Controls.Add(this.label3);
            this.groupBoxInfoProduit.Controls.Add(this.label4);
            this.groupBoxInfoProduit.Controls.Add(this.label5);
            this.groupBoxInfoProduit.Controls.Add(this.label6);
            this.groupBoxInfoProduit.Controls.Add(this.prix);
            this.groupBoxInfoProduit.Controls.Add(this.txt_id_produit);
            this.groupBoxInfoProduit.Controls.Add(this.txt_designation_produit);
            this.groupBoxInfoProduit.Controls.Add(this.num_qte_stock);
            this.groupBoxInfoProduit.Controls.Add(this.price);
            this.groupBoxInfoProduit.Controls.Add(this.comboBox_catego);
            this.groupBoxInfoProduit.Controls.Add(this.pic_image_produit);
            this.groupBoxInfoProduit.Controls.Add(this.btn_parcourir);
            this.groupBoxInfoProduit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxInfoProduit.Location = new System.Drawing.Point(16, 81);
            this.groupBoxInfoProduit.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxInfoProduit.Name = "groupBoxInfoProduit";
            this.groupBoxInfoProduit.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxInfoProduit.Size = new System.Drawing.Size(350, 300);
            this.groupBoxInfoProduit.TabIndex = 1;
            this.groupBoxInfoProduit.TabStop = false;
            this.groupBoxInfoProduit.Text = "Informations Produit";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID Produit";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Désignation";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Image";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Catégorie";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 220);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Quantité en stock";
            // 
            // prix
            // 
            this.prix.AutoSize = true;
            this.prix.Location = new System.Drawing.Point(20, 260);
            this.prix.Name = "prix";
            this.prix.Size = new System.Drawing.Size(38, 20);
            this.prix.TabIndex = 18;
            this.prix.Text = "Prix";
            this.prix.Click += new System.EventHandler(this.label7_Click);
            // 
            // txt_id_produit
            // 
            this.txt_id_produit.Location = new System.Drawing.Point(165, 40);
            this.txt_id_produit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_id_produit.Name = "txt_id_produit";
            this.txt_id_produit.Size = new System.Drawing.Size(160, 26);
            this.txt_id_produit.TabIndex = 6;
            this.txt_id_produit.TextChanged += new System.EventHandler(this.txt_id_produit_TextChanged);
            // 
            // txt_designation_produit
            // 
            this.txt_designation_produit.Location = new System.Drawing.Point(165, 80);
            this.txt_designation_produit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_designation_produit.Name = "txt_designation_produit";
            this.txt_designation_produit.Size = new System.Drawing.Size(160, 26);
            this.txt_designation_produit.TabIndex = 7;
            this.txt_designation_produit.TextChanged += new System.EventHandler(this.txt_designation_produit_TextChanged);
            // 
            // num_qte_stock
            // 
            this.num_qte_stock.Location = new System.Drawing.Point(165, 220);
            this.num_qte_stock.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.num_qte_stock.Name = "num_qte_stock";
            this.num_qte_stock.Size = new System.Drawing.Size(160, 26);
            this.num_qte_stock.TabIndex = 9;
            // 
            // price
            // 
            this.price.Location = new System.Drawing.Point(165, 260);
            this.price.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(160, 26);
            this.price.TabIndex = 19;
            // 
            // comboBox_catego
            // 
            this.comboBox_catego.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_catego.FormattingEnabled = true;
            this.comboBox_catego.Location = new System.Drawing.Point(165, 180);
            this.comboBox_catego.Name = "comboBox_catego";
            this.comboBox_catego.Size = new System.Drawing.Size(160, 28);
            this.comboBox_catego.TabIndex = 17;
            this.comboBox_catego.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // pic_image_produit
            // 
            this.pic_image_produit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic_image_produit.Location = new System.Drawing.Point(165, 120);
            this.pic_image_produit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pic_image_produit.Name = "pic_image_produit";
            this.pic_image_produit.Size = new System.Drawing.Size(80, 50);
            this.pic_image_produit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_image_produit.TabIndex = 10;
            this.pic_image_produit.TabStop = false;
            // 
            // btn_parcourir
            // 
            this.btn_parcourir.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_parcourir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_parcourir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_parcourir.ForeColor = System.Drawing.Color.White;
            this.btn_parcourir.Location = new System.Drawing.Point(255, 120);
            this.btn_parcourir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_parcourir.Name = "btn_parcourir";
            this.btn_parcourir.Size = new System.Drawing.Size(70, 30);
            this.btn_parcourir.TabIndex = 14;
            this.btn_parcourir.Text = "Parcourir";
            this.btn_parcourir.UseVisualStyleBackColor = false;
            this.btn_parcourir.Click += new System.EventHandler(this.btn_parcourir_Click);
            // 
            // groupBoxActions
            // 
            this.groupBoxActions.Controls.Add(this.btn_ajouter);
            this.groupBoxActions.Controls.Add(this.btn_modifier);
            this.groupBoxActions.Controls.Add(this.btn_supprimer);
            this.groupBoxActions.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxActions.Location = new System.Drawing.Point(16, 390);
            this.groupBoxActions.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxActions.Name = "groupBoxActions";
            this.groupBoxActions.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxActions.Size = new System.Drawing.Size(350, 100);
            this.groupBoxActions.TabIndex = 2;
            this.groupBoxActions.TabStop = false;
            this.groupBoxActions.Text = "Actions";
            // 
            // btn_ajouter
            // 
            this.btn_ajouter.BackColor = System.Drawing.Color.ForestGreen;
            this.btn_ajouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ajouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ajouter.ForeColor = System.Drawing.Color.White;
            this.btn_ajouter.Location = new System.Drawing.Point(20, 37);
            this.btn_ajouter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_ajouter.Name = "btn_ajouter";
            this.btn_ajouter.Size = new System.Drawing.Size(95, 40);
            this.btn_ajouter.TabIndex = 11;
            this.btn_ajouter.Text = "Ajouter";
            this.btn_ajouter.UseVisualStyleBackColor = false;
            this.btn_ajouter.Click += new System.EventHandler(this.btn_ajouter_Click);
            // 
            // btn_modifier
            // 
            this.btn_modifier.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_modifier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_modifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_modifier.ForeColor = System.Drawing.Color.White;
            this.btn_modifier.Location = new System.Drawing.Point(127, 37);
            this.btn_modifier.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_modifier.Name = "btn_modifier";
            this.btn_modifier.Size = new System.Drawing.Size(95, 40);
            this.btn_modifier.TabIndex = 12;
            this.btn_modifier.Text = "Modifier";
            this.btn_modifier.UseVisualStyleBackColor = false;
            this.btn_modifier.Click += new System.EventHandler(this.btn_modifier_Click);
            // 
            // btn_supprimer
            // 
            this.btn_supprimer.BackColor = System.Drawing.Color.Firebrick;
            this.btn_supprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_supprimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_supprimer.ForeColor = System.Drawing.Color.White;
            this.btn_supprimer.Location = new System.Drawing.Point(234, 37);
            this.btn_supprimer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_supprimer.Name = "btn_supprimer";
            this.btn_supprimer.Size = new System.Drawing.Size(95, 40);
            this.btn_supprimer.TabIndex = 13;
            this.btn_supprimer.Text = "Supprimer";
            this.btn_supprimer.UseVisualStyleBackColor = false;
            this.btn_supprimer.Click += new System.EventHandler(this.btn_supprimer_Click);
            // 
            // groupBoxListeProduits
            // 
            this.groupBoxListeProduits.Controls.Add(this.dataGridView_produits);
            this.groupBoxListeProduits.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxListeProduits.Location = new System.Drawing.Point(374, 81);
            this.groupBoxListeProduits.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxListeProduits.Name = "groupBoxListeProduits";
            this.groupBoxListeProduits.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxListeProduits.Size = new System.Drawing.Size(466, 409);
            this.groupBoxListeProduits.TabIndex = 3;
            this.groupBoxListeProduits.TabStop = false;
            this.groupBoxListeProduits.Text = "Liste des Produits";
            // 
            // dataGridView_produits
            // 
            this.dataGridView_produits.AllowUserToAddRows = false;
            this.dataGridView_produits.AllowUserToDeleteRows = false;
            this.dataGridView_produits.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView_produits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_produits.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_produits.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView_produits.Location = new System.Drawing.Point(4, 23);
            this.dataGridView_produits.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView_produits.Name = "dataGridView_produits";
            this.dataGridView_produits.ReadOnly = true;
            this.dataGridView_produits.RowHeadersWidth = 51;
            this.dataGridView_produits.RowTemplate.Height = 24;
            this.dataGridView_produits.Size = new System.Drawing.Size(458, 382);
            this.dataGridView_produits.TabIndex = 16;
            this.dataGridView_produits.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_produits_CellContentClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // GestionProduits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1099, 607);
            this.Controls.Add(this.groupBoxListeProduits);
            this.Controls.Add(this.groupBoxActions);
            this.Controls.Add(this.groupBoxInfoProduit);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(872, 538);
            this.Name = "GestionProduits";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion des Produits";
            this.Load += new System.EventHandler(this.GestionProduits_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBoxInfoProduit.ResumeLayout(false);
            this.groupBoxInfoProduit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_image_produit)).EndInit();
            this.groupBoxActions.ResumeLayout(false);
            this.groupBoxListeProduits.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_produits)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_id_produit;
        private System.Windows.Forms.TextBox txt_designation_produit;
        private System.Windows.Forms.TextBox num_qte_stock;
        private System.Windows.Forms.PictureBox pic_image_produit;
        private System.Windows.Forms.Button btn_ajouter;
        private System.Windows.Forms.Button btn_modifier;
        private System.Windows.Forms.Button btn_supprimer;
        private System.Windows.Forms.Button btn_parcourir;
        private System.Windows.Forms.Button btn_retour;
        private System.Windows.Forms.DataGridView dataGridView_produits;
        private System.Windows.Forms.ComboBox comboBox_catego;
        private System.Windows.Forms.Label prix;
        private System.Windows.Forms.TextBox price;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.GroupBox groupBoxInfoProduit;
        private System.Windows.Forms.GroupBox groupBoxActions;
        private System.Windows.Forms.GroupBox groupBoxListeProduits;
    }
}