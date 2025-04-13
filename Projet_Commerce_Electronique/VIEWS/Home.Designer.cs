namespace Projet_Commerce_Electronique.VIEWS
{
    partial class Home
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.btn_clients = new System.Windows.Forms.Button();
            this.btn_produits = new System.Windows.Forms.Button();
            this.btn_commandes = new System.Windows.Forms.Button();
            this.btn_quitter = new System.Windows.Forms.Button();
            this.btn_categories = new System.Windows.Forms.Button();
            this.panel_header = new System.Windows.Forms.Panel();
            this.lbl_title = new System.Windows.Forms.Label();
            this.panel_header.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_clients
            // 
            this.btn_clients.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_clients.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clients.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clients.ForeColor = System.Drawing.Color.Black;
            this.btn_clients.Location = new System.Drawing.Point(26, 120);
            this.btn_clients.Name = "btn_clients";
            this.btn_clients.Size = new System.Drawing.Size(258, 50);
            this.btn_clients.TabIndex = 1;
            this.btn_clients.Text = "Gestion Clients";
            this.btn_clients.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btn_clients.UseVisualStyleBackColor = false;
            this.btn_clients.Click += new System.EventHandler(this.btn_clients_Click);
            // 
            // btn_produits
            // 
            this.btn_produits.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_produits.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_produits.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_produits.ForeColor = System.Drawing.Color.Black;
            this.btn_produits.Location = new System.Drawing.Point(26, 194);
            this.btn_produits.Name = "btn_produits";
            this.btn_produits.Size = new System.Drawing.Size(258, 50);
            this.btn_produits.TabIndex = 2;
            this.btn_produits.Text = "Gestion Produits";
            this.btn_produits.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btn_produits.UseVisualStyleBackColor = false;
            this.btn_produits.Click += new System.EventHandler(this.btn_produits_Click);
            // 
            // btn_commandes
            // 
            this.btn_commandes.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_commandes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_commandes.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_commandes.ForeColor = System.Drawing.Color.Black;
            this.btn_commandes.Location = new System.Drawing.Point(26, 531);
            this.btn_commandes.Name = "btn_commandes";
            this.btn_commandes.Size = new System.Drawing.Size(258, 50);
            this.btn_commandes.TabIndex = 3;
            this.btn_commandes.Text = "Gestion Commandes";
            this.btn_commandes.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btn_commandes.UseVisualStyleBackColor = false;
            this.btn_commandes.Click += new System.EventHandler(this.btn_commandes_Click);
            // 
            // btn_quitter
            // 
            this.btn_quitter.BackColor = System.Drawing.Color.Crimson;
            this.btn_quitter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_quitter.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btn_quitter.ForeColor = System.Drawing.Color.White;
            this.btn_quitter.Location = new System.Drawing.Point(985, 602);
            this.btn_quitter.Name = "btn_quitter";
            this.btn_quitter.Size = new System.Drawing.Size(90, 35);
            this.btn_quitter.TabIndex = 5;
            this.btn_quitter.Text = "Quitter";
            this.btn_quitter.UseVisualStyleBackColor = false;
            this.btn_quitter.Click += new System.EventHandler(this.btn_quitter_Click);
            // 
            // btn_categories
            // 
            this.btn_categories.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_categories.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_categories.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_categories.ForeColor = System.Drawing.Color.Black;
            this.btn_categories.Location = new System.Drawing.Point(26, 587);
            this.btn_categories.Name = "btn_categories";
            this.btn_categories.Size = new System.Drawing.Size(258, 50);
            this.btn_categories.TabIndex = 4;
            this.btn_categories.Text = "Gestion Catégories";
            this.btn_categories.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btn_categories.UseVisualStyleBackColor = false;
            this.btn_categories.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel_header
            // 
            this.panel_header.BackColor = System.Drawing.Color.OrangeRed;
            this.panel_header.Controls.Add(this.lbl_title);
            this.panel_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_header.Location = new System.Drawing.Point(0, 0);
            this.panel_header.Name = "panel_header";
            this.panel_header.Size = new System.Drawing.Size(1087, 80);
            this.panel_header.TabIndex = 0;
            // 
            // lbl_title
            // 
            this.lbl_title.BackColor = System.Drawing.Color.RoyalBlue;
            this.lbl_title.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_title.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lbl_title.ForeColor = System.Drawing.Color.White;
            this.lbl_title.Location = new System.Drawing.Point(0, 0);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(1087, 80);
            this.lbl_title.TabIndex = 0;
            this.lbl_title.Text = "Tableau de bord - E-Commerce";
            this.lbl_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Home
            // 
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImage = global::Projet_Commerce_Electronique.Properties.Resources.e_commerce_6898102_1280;
            this.ClientSize = new System.Drawing.Size(1087, 660);
            this.Controls.Add(this.btn_quitter);
            this.Controls.Add(this.btn_categories);
            this.Controls.Add(this.btn_commandes);
            this.Controls.Add(this.btn_produits);
            this.Controls.Add(this.btn_clients);
            this.Controls.Add(this.panel_header);
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Accueil";
            this.Load += new System.EventHandler(this.Home_Load);
            this.panel_header.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_header;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Button btn_clients;
        private System.Windows.Forms.Button btn_produits;
        private System.Windows.Forms.Button btn_commandes;
        private System.Windows.Forms.Button btn_categories;
        private System.Windows.Forms.Button btn_quitter;
    }
}
