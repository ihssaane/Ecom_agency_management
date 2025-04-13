namespace Projet_Commerce_Electronique.VIEWS
{
    partial class categories
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_retour = new System.Windows.Forms.Button();
            this.groupBoxInfoCategorie = new System.Windows.Forms.GroupBox();
            this.id_cat = new System.Windows.Forms.Label();
            this.nom_cat = new System.Windows.Forms.Label();
            this.id_cattt = new System.Windows.Forms.TextBox();
            this.nom_catt = new System.Windows.Forms.TextBox();
            this.groupBoxActions = new System.Windows.Forms.GroupBox();
            this.btn_ajouter = new System.Windows.Forms.Button();
            this.btn_modifier = new System.Windows.Forms.Button();
            this.btn_supprimer = new System.Windows.Forms.Button();
            this.groupBoxListeCategories = new System.Windows.Forms.GroupBox();
            this.dataGridView_categories = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.groupBoxInfoCategorie.SuspendLayout();
            this.groupBoxActions.SuspendLayout();
            this.groupBoxListeCategories.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_categories)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(1073, 74);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(16, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(347, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gestion des Catégories";
            // 
            // btn_retour
            // 
            this.btn_retour.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_retour.BackColor = System.Drawing.Color.White;
            this.btn_retour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_retour.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_retour.Location = new System.Drawing.Point(941, 18);
            this.btn_retour.Margin = new System.Windows.Forms.Padding(4);
            this.btn_retour.Name = "btn_retour";
            this.btn_retour.Size = new System.Drawing.Size(115, 37);
            this.btn_retour.TabIndex = 32;
            this.btn_retour.Text = "Retour";
            this.btn_retour.UseVisualStyleBackColor = false;
            this.btn_retour.Click += new System.EventHandler(this.btn_retour_Click);
            // 
            // groupBoxInfoCategorie
            // 
            this.groupBoxInfoCategorie.Controls.Add(this.id_cat);
            this.groupBoxInfoCategorie.Controls.Add(this.nom_cat);
            this.groupBoxInfoCategorie.Controls.Add(this.id_cattt);
            this.groupBoxInfoCategorie.Controls.Add(this.nom_catt);
            this.groupBoxInfoCategorie.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxInfoCategorie.Location = new System.Drawing.Point(16, 81);
            this.groupBoxInfoCategorie.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxInfoCategorie.Name = "groupBoxInfoCategorie";
            this.groupBoxInfoCategorie.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxInfoCategorie.Size = new System.Drawing.Size(350, 150);
            this.groupBoxInfoCategorie.TabIndex = 1;
            this.groupBoxInfoCategorie.TabStop = false;
            this.groupBoxInfoCategorie.Text = "Informations Catégorie";
            // 
            // id_cat
            // 
            this.id_cat.AutoSize = true;
            this.id_cat.Location = new System.Drawing.Point(20, 40);
            this.id_cat.Name = "id_cat";
            this.id_cat.Size = new System.Drawing.Size(103, 20);
            this.id_cat.TabIndex = 18;
            this.id_cat.Text = "ID Catégorie";
            // 
            // nom_cat
            // 
            this.nom_cat.AutoSize = true;
            this.nom_cat.Location = new System.Drawing.Point(20, 80);
            this.nom_cat.Name = "nom_cat";
            this.nom_cat.Size = new System.Drawing.Size(121, 20);
            this.nom_cat.TabIndex = 19;
            this.nom_cat.Text = "Nom Catégorie";
            // 
            // id_cattt
            // 
            this.id_cattt.Location = new System.Drawing.Point(165, 40);
            this.id_cattt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.id_cattt.Name = "id_cattt";
            this.id_cattt.Size = new System.Drawing.Size(160, 26);
            this.id_cattt.TabIndex = 23;
            // 
            // nom_catt
            // 
            this.nom_catt.Location = new System.Drawing.Point(165, 80);
            this.nom_catt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nom_catt.Name = "nom_catt";
            this.nom_catt.Size = new System.Drawing.Size(160, 26);
            this.nom_catt.TabIndex = 24;
            this.nom_catt.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // groupBoxActions
            // 
            this.groupBoxActions.Controls.Add(this.btn_ajouter);
            this.groupBoxActions.Controls.Add(this.btn_modifier);
            this.groupBoxActions.Controls.Add(this.btn_supprimer);
            this.groupBoxActions.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxActions.Location = new System.Drawing.Point(16, 240);
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
            this.btn_ajouter.TabIndex = 28;
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
            this.btn_modifier.TabIndex = 29;
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
            this.btn_supprimer.Size = new System.Drawing.Size(109, 40);
            this.btn_supprimer.TabIndex = 30;
            this.btn_supprimer.Text = "Supprimer";
            this.btn_supprimer.UseVisualStyleBackColor = false;
            this.btn_supprimer.Click += new System.EventHandler(this.btn_supprimer_Click);
            // 
            // groupBoxListeCategories
            // 
            this.groupBoxListeCategories.Controls.Add(this.dataGridView_categories);
            this.groupBoxListeCategories.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxListeCategories.Location = new System.Drawing.Point(374, 81);
            this.groupBoxListeCategories.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxListeCategories.Name = "groupBoxListeCategories";
            this.groupBoxListeCategories.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxListeCategories.Size = new System.Drawing.Size(410, 359);
            this.groupBoxListeCategories.TabIndex = 3;
            this.groupBoxListeCategories.TabStop = false;
            this.groupBoxListeCategories.Text = "Liste des Catégories";
            // 
            // dataGridView_categories
            // 
            this.dataGridView_categories.AllowUserToAddRows = false;
            this.dataGridView_categories.AllowUserToDeleteRows = false;
            this.dataGridView_categories.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView_categories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_categories.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_categories.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView_categories.Location = new System.Drawing.Point(4, 23);
            this.dataGridView_categories.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView_categories.Name = "dataGridView_categories";
            this.dataGridView_categories.ReadOnly = true;
            this.dataGridView_categories.RowHeadersWidth = 51;
            this.dataGridView_categories.RowTemplate.Height = 24;
            this.dataGridView_categories.Size = new System.Drawing.Size(402, 332);
            this.dataGridView_categories.TabIndex = 38;
            this.dataGridView_categories.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_categories_CellClick);
            // 
            // categories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1073, 648);
            this.Controls.Add(this.groupBoxListeCategories);
            this.Controls.Add(this.groupBoxActions);
            this.Controls.Add(this.groupBoxInfoCategorie);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(816, 488);
            this.Name = "categories";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion des Catégories";
            this.Load += new System.EventHandler(this.categories_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBoxInfoCategorie.ResumeLayout(false);
            this.groupBoxInfoCategorie.PerformLayout();
            this.groupBoxActions.ResumeLayout(false);
            this.groupBoxListeCategories.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_categories)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_retour;
        private System.Windows.Forms.GroupBox groupBoxInfoCategorie;
        private System.Windows.Forms.Label id_cat;
        private System.Windows.Forms.Label nom_cat;
        private System.Windows.Forms.TextBox id_cattt;
        private System.Windows.Forms.TextBox nom_catt;
        private System.Windows.Forms.GroupBox groupBoxActions;
        private System.Windows.Forms.Button btn_ajouter;
        private System.Windows.Forms.Button btn_modifier;
        private System.Windows.Forms.Button btn_supprimer;
        private System.Windows.Forms.GroupBox groupBoxListeCategories;
        private System.Windows.Forms.DataGridView dataGridView_categories;
    }
}