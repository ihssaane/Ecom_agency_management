namespace Projet_Commerce_Electronique.VIEWS
{
    partial class GestionCommandes
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
            this.lblDateCommande = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRetour = new System.Windows.Forms.Button();
            this.groupBoxClient = new System.Windows.Forms.GroupBox();
            this.lblClientSelectionne = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbClients = new System.Windows.Forms.ComboBox();
            this.groupBoxProduits = new System.Windows.Forms.GroupBox();
            this.btnAjouterAuPanier = new System.Windows.Forms.Button();
            this.txtQuantite = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbProduits = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBoxPanier = new System.Windows.Forms.GroupBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.dgvPanier = new System.Windows.Forms.DataGridView();
            this.groupBoxActions = new System.Windows.Forms.GroupBox();
            this.btnAnnulerCommande = new System.Windows.Forms.Button();
            this.btnValiderCommande = new System.Windows.Forms.Button();
            this.groupBoxHistorique = new System.Windows.Forms.GroupBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dgvCommandesPrecedentes = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTotalDetails = new System.Windows.Forms.Label();
            this.dgvDetailsCommande = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBoxClient.SuspendLayout();
            this.groupBoxProduits.SuspendLayout();
            this.groupBoxPanier.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPanier)).BeginInit();
            this.groupBoxActions.SuspendLayout();
            this.groupBoxHistorique.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCommandesPrecedentes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetailsCommande)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.lblDateCommande);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnRetour);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1579, 74);
            this.panel1.TabIndex = 0;
            // 
            // lblDateCommande
            // 
            this.lblDateCommande.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateCommande.ForeColor = System.Drawing.Color.White;
            this.lblDateCommande.Location = new System.Drawing.Point(639, 18);
            this.lblDateCommande.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDateCommande.Name = "lblDateCommande";
            this.lblDateCommande.Size = new System.Drawing.Size(333, 36);
            this.lblDateCommande.TabIndex = 2;
            this.lblDateCommande.Text = "Date: 05/04/2025";
            this.lblDateCommande.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(16, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(368, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Gestion des Commandes";
            // 
            // btnRetour
            // 
            this.btnRetour.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRetour.BackColor = System.Drawing.Color.White;
            this.btnRetour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRetour.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetour.Location = new System.Drawing.Point(1448, 18);
            this.btnRetour.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(115, 37);
            this.btnRetour.TabIndex = 0;
            this.btnRetour.Text = "Retour";
            this.btnRetour.UseVisualStyleBackColor = false;
            this.btnRetour.Click += new System.EventHandler(this.btnRetour_Click);
            // 
            // groupBoxClient
            // 
            this.groupBoxClient.Controls.Add(this.lblClientSelectionne);
            this.groupBoxClient.Controls.Add(this.label2);
            this.groupBoxClient.Controls.Add(this.cmbClients);
            this.groupBoxClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxClient.Location = new System.Drawing.Point(16, 81);
            this.groupBoxClient.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxClient.Name = "groupBoxClient";
            this.groupBoxClient.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxClient.Size = new System.Drawing.Size(772, 123);
            this.groupBoxClient.TabIndex = 1;
            this.groupBoxClient.TabStop = false;
            this.groupBoxClient.Text = "Sélection du Client";
            // 
            // lblClientSelectionne
            // 
            this.lblClientSelectionne.AutoSize = true;
            this.lblClientSelectionne.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientSelectionne.Location = new System.Drawing.Point(21, 84);
            this.lblClientSelectionne.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblClientSelectionne.Name = "lblClientSelectionne";
            this.lblClientSelectionne.Size = new System.Drawing.Size(215, 20);
            this.lblClientSelectionne.TabIndex = 2;
            this.lblClientSelectionne.Text = "Aucun client sélectionné";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 41);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Client :";
            // 
            // cmbClients
            // 
            this.cmbClients.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbClients.FormattingEnabled = true;
            this.cmbClients.Location = new System.Drawing.Point(89, 37);
            this.cmbClients.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbClients.Name = "cmbClients";
            this.cmbClients.Size = new System.Drawing.Size(656, 28);
            this.cmbClients.TabIndex = 0;
            this.cmbClients.SelectedIndexChanged += new System.EventHandler(this.cmbClients_SelectedIndexChanged);
            // 
            // groupBoxProduits
            // 
            this.groupBoxProduits.Controls.Add(this.btnAjouterAuPanier);
            this.groupBoxProduits.Controls.Add(this.txtQuantite);
            this.groupBoxProduits.Controls.Add(this.label4);
            this.groupBoxProduits.Controls.Add(this.cmbProduits);
            this.groupBoxProduits.Controls.Add(this.label3);
            this.groupBoxProduits.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxProduits.Location = new System.Drawing.Point(16, 212);
            this.groupBoxProduits.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxProduits.Name = "groupBoxProduits";
            this.groupBoxProduits.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxProduits.Size = new System.Drawing.Size(772, 146);
            this.groupBoxProduits.TabIndex = 2;
            this.groupBoxProduits.TabStop = false;
            this.groupBoxProduits.Text = "Ajout de Produits";
            // 
            // btnAjouterAuPanier
            // 
            this.btnAjouterAuPanier.BackColor = System.Drawing.Color.ForestGreen;
            this.btnAjouterAuPanier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjouterAuPanier.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouterAuPanier.ForeColor = System.Drawing.Color.White;
            this.btnAjouterAuPanier.Location = new System.Drawing.Point(520, 82);
            this.btnAjouterAuPanier.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAjouterAuPanier.Name = "btnAjouterAuPanier";
            this.btnAjouterAuPanier.Size = new System.Drawing.Size(227, 43);
            this.btnAjouterAuPanier.TabIndex = 4;
            this.btnAjouterAuPanier.Text = "Ajouter au Panier";
            this.btnAjouterAuPanier.UseVisualStyleBackColor = false;
            this.btnAjouterAuPanier.Click += new System.EventHandler(this.btnAjouterAuPanier_Click);
            // 
            // txtQuantite
            // 
            this.txtQuantite.Location = new System.Drawing.Point(123, 82);
            this.txtQuantite.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtQuantite.Name = "txtQuantite";
            this.txtQuantite.Size = new System.Drawing.Size(92, 26);
            this.txtQuantite.TabIndex = 3;
            this.txtQuantite.Text = "1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 86);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Quantité :";
            // 
            // cmbProduits
            // 
            this.cmbProduits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProduits.FormattingEnabled = true;
            this.cmbProduits.Location = new System.Drawing.Point(123, 36);
            this.cmbProduits.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbProduits.Name = "cmbProduits";
            this.cmbProduits.Size = new System.Drawing.Size(623, 28);
            this.cmbProduits.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 39);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Produit :";
            // 
            // groupBoxPanier
            // 
            this.groupBoxPanier.Controls.Add(this.lblTotal);
            this.groupBoxPanier.Controls.Add(this.dgvPanier);
            this.groupBoxPanier.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxPanier.Location = new System.Drawing.Point(16, 366);
            this.groupBoxPanier.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxPanier.Name = "groupBoxPanier";
            this.groupBoxPanier.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxPanier.Size = new System.Drawing.Size(772, 284);
            this.groupBoxPanier.TabIndex = 3;
            this.groupBoxPanier.TabStop = false;
            this.groupBoxPanier.Text = "Panier";
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(451, 241);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(296, 31);
            this.lblTotal.TabIndex = 1;
            this.lblTotal.Text = "Total : 0,00 DH";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dgvPanier
            // 
            this.dgvPanier.AllowUserToAddRows = false;
            this.dgvPanier.AllowUserToDeleteRows = false;
            this.dgvPanier.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvPanier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPanier.Location = new System.Drawing.Point(8, 26);
            this.dgvPanier.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvPanier.Name = "dgvPanier";
            this.dgvPanier.ReadOnly = true;
            this.dgvPanier.RowHeadersWidth = 51;
            this.dgvPanier.Size = new System.Drawing.Size(756, 212);
            this.dgvPanier.TabIndex = 0;
            this.dgvPanier.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPanier_CellContentClick);
            // 
            // groupBoxActions
            // 
            this.groupBoxActions.Controls.Add(this.btnAnnulerCommande);
            this.groupBoxActions.Controls.Add(this.btnValiderCommande);
            this.groupBoxActions.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxActions.Location = new System.Drawing.Point(16, 657);
            this.groupBoxActions.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxActions.Name = "groupBoxActions";
            this.groupBoxActions.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxActions.Size = new System.Drawing.Size(772, 105);
            this.groupBoxActions.TabIndex = 4;
            this.groupBoxActions.TabStop = false;
            this.groupBoxActions.Text = "Actions";
            // 
            // btnAnnulerCommande
            // 
            this.btnAnnulerCommande.BackColor = System.Drawing.Color.Firebrick;
            this.btnAnnulerCommande.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnnulerCommande.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnulerCommande.ForeColor = System.Drawing.Color.White;
            this.btnAnnulerCommande.Location = new System.Drawing.Point(392, 37);
            this.btnAnnulerCommande.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAnnulerCommande.Name = "btnAnnulerCommande";
            this.btnAnnulerCommande.Size = new System.Drawing.Size(355, 49);
            this.btnAnnulerCommande.TabIndex = 1;
            this.btnAnnulerCommande.Text = "Annuler la Commande";
            this.btnAnnulerCommande.UseVisualStyleBackColor = false;
            this.btnAnnulerCommande.Click += new System.EventHandler(this.btnAnnulerCommande_Click);
            // 
            // btnValiderCommande
            // 
            this.btnValiderCommande.BackColor = System.Drawing.Color.ForestGreen;
            this.btnValiderCommande.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnValiderCommande.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValiderCommande.ForeColor = System.Drawing.Color.White;
            this.btnValiderCommande.Location = new System.Drawing.Point(25, 37);
            this.btnValiderCommande.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnValiderCommande.Name = "btnValiderCommande";
            this.btnValiderCommande.Size = new System.Drawing.Size(355, 49);
            this.btnValiderCommande.TabIndex = 0;
            this.btnValiderCommande.Text = "Valider la Commande";
            this.btnValiderCommande.UseVisualStyleBackColor = false;
            this.btnValiderCommande.Click += new System.EventHandler(this.btnValiderCommande_Click);
            // 
            // groupBoxHistorique
            // 
            this.groupBoxHistorique.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxHistorique.Controls.Add(this.splitContainer1);
            this.groupBoxHistorique.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxHistorique.Location = new System.Drawing.Point(796, 81);
            this.groupBoxHistorique.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxHistorique.Name = "groupBoxHistorique";
            this.groupBoxHistorique.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxHistorique.Size = new System.Drawing.Size(767, 681);
            this.groupBoxHistorique.TabIndex = 5;
            this.groupBoxHistorique.TabStop = false;
            this.groupBoxHistorique.Text = "Historique des Commandes";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(4, 23);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dgvCommandesPrecedentes);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.lblTotalDetails);
            this.splitContainer1.Panel2.Controls.Add(this.dgvDetailsCommande);
            this.splitContainer1.Panel2.Controls.Add(this.label6);
            this.splitContainer1.Size = new System.Drawing.Size(759, 654);
            this.splitContainer1.SplitterDistance = 311;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 0;
            // 
            // dgvCommandesPrecedentes
            // 
            this.dgvCommandesPrecedentes.AllowUserToAddRows = false;
            this.dgvCommandesPrecedentes.AllowUserToDeleteRows = false;
            this.dgvCommandesPrecedentes.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvCommandesPrecedentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCommandesPrecedentes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCommandesPrecedentes.Location = new System.Drawing.Point(0, 28);
            this.dgvCommandesPrecedentes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvCommandesPrecedentes.Name = "dgvCommandesPrecedentes";
            this.dgvCommandesPrecedentes.ReadOnly = true;
            this.dgvCommandesPrecedentes.RowHeadersWidth = 51;
            this.dgvCommandesPrecedentes.Size = new System.Drawing.Size(759, 283);
            this.dgvCommandesPrecedentes.TabIndex = 1;
            this.dgvCommandesPrecedentes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCommandesPrecedentes_CellClick);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.SteelBlue;
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(759, 28);
            this.label5.TabIndex = 0;
            this.label5.Text = "Commandes Précédentes";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalDetails
            // 
            this.lblTotalDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalDetails.Location = new System.Drawing.Point(400, 299);
            this.lblTotalDetails.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalDetails.Name = "lblTotalDetails";
            this.lblTotalDetails.Size = new System.Drawing.Size(355, 27);
            this.lblTotalDetails.TabIndex = 2;
            this.lblTotalDetails.Text = "Total de la commande: 0,00 DH";
            this.lblTotalDetails.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dgvDetailsCommande
            // 
            this.dgvDetailsCommande.AllowUserToAddRows = false;
            this.dgvDetailsCommande.AllowUserToDeleteRows = false;
            this.dgvDetailsCommande.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvDetailsCommande.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetailsCommande.Location = new System.Drawing.Point(0, 28);
            this.dgvDetailsCommande.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvDetailsCommande.Name = "dgvDetailsCommande";
            this.dgvDetailsCommande.ReadOnly = true;
            this.dgvDetailsCommande.RowHeadersWidth = 51;
            this.dgvDetailsCommande.Size = new System.Drawing.Size(759, 267);
            this.dgvDetailsCommande.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.SteelBlue;
            this.label6.Dock = System.Windows.Forms.DockStyle.Top;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(759, 28);
            this.label6.TabIndex = 0;
            this.label6.Text = "Détails de la Commande";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GestionCommandes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1579, 777);
            this.Controls.Add(this.groupBoxHistorique);
            this.Controls.Add(this.groupBoxActions);
            this.Controls.Add(this.groupBoxPanier);
            this.Controls.Add(this.groupBoxProduits);
            this.Controls.Add(this.groupBoxClient);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimumSize = new System.Drawing.Size(1594, 814);
            this.Name = "GestionCommandes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion des Commandes";
            this.Load += new System.EventHandler(this.GestionCommandes_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBoxClient.ResumeLayout(false);
            this.groupBoxClient.PerformLayout();
            this.groupBoxProduits.ResumeLayout(false);
            this.groupBoxProduits.PerformLayout();
            this.groupBoxPanier.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPanier)).EndInit();
            this.groupBoxActions.ResumeLayout(false);
            this.groupBoxHistorique.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCommandesPrecedentes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetailsCommande)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRetour;
        private System.Windows.Forms.GroupBox groupBoxClient;
        private System.Windows.Forms.Label lblClientSelectionne;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbClients;
        private System.Windows.Forms.GroupBox groupBoxProduits;
        private System.Windows.Forms.Button btnAjouterAuPanier;
        private System.Windows.Forms.TextBox txtQuantite;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbProduits;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBoxPanier;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.DataGridView dgvPanier;
        private System.Windows.Forms.GroupBox groupBoxActions;
        private System.Windows.Forms.Button btnAnnulerCommande;
        private System.Windows.Forms.Button btnValiderCommande;
        private System.Windows.Forms.GroupBox groupBoxHistorique;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dgvCommandesPrecedentes;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvDetailsCommande;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblDateCommande;
        private System.Windows.Forms.Label lblTotalDetails;
    }
}