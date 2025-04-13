namespace Projet_Commerce_Electronique.VIEWS
{
    partial class GestionClients
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
            this.groupBoxInfoClient = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_id_client = new System.Windows.Forms.TextBox();
            this.txt_nom_client = new System.Windows.Forms.TextBox();
            this.txt_prenom_client = new System.Windows.Forms.TextBox();
            this.txt_adresse = new System.Windows.Forms.TextBox();
            this.txt_telephone = new System.Windows.Forms.TextBox();
            this.groupBoxActions = new System.Windows.Forms.GroupBox();
            this.btn_ajouter = new System.Windows.Forms.Button();
            this.btn_modifier = new System.Windows.Forms.Button();
            this.btn_supprimer = new System.Windows.Forms.Button();
            this.groupBoxListeClients = new System.Windows.Forms.GroupBox();
            this.dataGridView_clients = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.groupBoxInfoClient.SuspendLayout();
            this.groupBoxActions.SuspendLayout();
            this.groupBoxListeClients.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_clients)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(1094, 74);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(16, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(292, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gestion des Clients";
            // 
            // btn_retour
            // 
            this.btn_retour.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_retour.BackColor = System.Drawing.Color.White;
            this.btn_retour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_retour.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_retour.Location = new System.Drawing.Point(962, 18);
            this.btn_retour.Margin = new System.Windows.Forms.Padding(4);
            this.btn_retour.Name = "btn_retour";
            this.btn_retour.Size = new System.Drawing.Size(115, 37);
            this.btn_retour.TabIndex = 32;
            this.btn_retour.Text = "Retour";
            this.btn_retour.UseVisualStyleBackColor = false;
            this.btn_retour.Click += new System.EventHandler(this.btn_retour_Click);
            // 
            // groupBoxInfoClient
            // 
            this.groupBoxInfoClient.Controls.Add(this.label2);
            this.groupBoxInfoClient.Controls.Add(this.label3);
            this.groupBoxInfoClient.Controls.Add(this.label7);
            this.groupBoxInfoClient.Controls.Add(this.label5);
            this.groupBoxInfoClient.Controls.Add(this.label6);
            this.groupBoxInfoClient.Controls.Add(this.txt_id_client);
            this.groupBoxInfoClient.Controls.Add(this.txt_nom_client);
            this.groupBoxInfoClient.Controls.Add(this.txt_prenom_client);
            this.groupBoxInfoClient.Controls.Add(this.txt_adresse);
            this.groupBoxInfoClient.Controls.Add(this.txt_telephone);
            this.groupBoxInfoClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxInfoClient.Location = new System.Drawing.Point(16, 81);
            this.groupBoxInfoClient.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxInfoClient.Name = "groupBoxInfoClient";
            this.groupBoxInfoClient.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxInfoClient.Size = new System.Drawing.Size(350, 250);
            this.groupBoxInfoClient.TabIndex = 1;
            this.groupBoxInfoClient.TabStop = false;
            this.groupBoxInfoClient.Text = "Informations Client";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "ID Client";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "Nom Client";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 120);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 20);
            this.label7.TabIndex = 34;
            this.label7.Text = "Prénom Client";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 20);
            this.label5.TabIndex = 21;
            this.label5.Text = "Adresse";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 20);
            this.label6.TabIndex = 22;
            this.label6.Text = "Téléphone";
            // 
            // txt_id_client
            // 
            this.txt_id_client.Location = new System.Drawing.Point(165, 40);
            this.txt_id_client.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_id_client.Name = "txt_id_client";
            this.txt_id_client.Size = new System.Drawing.Size(160, 26);
            this.txt_id_client.TabIndex = 23;
            this.txt_id_client.TextChanged += new System.EventHandler(this.txt_id_client_TextChanged);
            // 
            // txt_nom_client
            // 
            this.txt_nom_client.Location = new System.Drawing.Point(165, 80);
            this.txt_nom_client.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_nom_client.Name = "txt_nom_client";
            this.txt_nom_client.Size = new System.Drawing.Size(160, 26);
            this.txt_nom_client.TabIndex = 24;
            // 
            // txt_prenom_client
            // 
            this.txt_prenom_client.Location = new System.Drawing.Point(165, 120);
            this.txt_prenom_client.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_prenom_client.Name = "txt_prenom_client";
            this.txt_prenom_client.Size = new System.Drawing.Size(160, 26);
            this.txt_prenom_client.TabIndex = 35;
            // 
            // txt_adresse
            // 
            this.txt_adresse.Location = new System.Drawing.Point(165, 160);
            this.txt_adresse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_adresse.Name = "txt_adresse";
            this.txt_adresse.Size = new System.Drawing.Size(160, 26);
            this.txt_adresse.TabIndex = 25;
            // 
            // txt_telephone
            // 
            this.txt_telephone.Location = new System.Drawing.Point(165, 200);
            this.txt_telephone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_telephone.Name = "txt_telephone";
            this.txt_telephone.Size = new System.Drawing.Size(160, 26);
            this.txt_telephone.TabIndex = 26;
            // 
            // groupBoxActions
            // 
            this.groupBoxActions.Controls.Add(this.btn_ajouter);
            this.groupBoxActions.Controls.Add(this.btn_modifier);
            this.groupBoxActions.Controls.Add(this.btn_supprimer);
            this.groupBoxActions.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxActions.Location = new System.Drawing.Point(16, 340);
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
            this.btn_supprimer.Size = new System.Drawing.Size(95, 40);
            this.btn_supprimer.TabIndex = 30;
            this.btn_supprimer.Text = "Supprimer";
            this.btn_supprimer.UseVisualStyleBackColor = false;
            this.btn_supprimer.Click += new System.EventHandler(this.btn_supprimer_Click);
            // 
            // groupBoxListeClients
            // 
            this.groupBoxListeClients.Controls.Add(this.dataGridView_clients);
            this.groupBoxListeClients.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxListeClients.Location = new System.Drawing.Point(374, 81);
            this.groupBoxListeClients.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxListeClients.Name = "groupBoxListeClients";
            this.groupBoxListeClients.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxListeClients.Size = new System.Drawing.Size(474, 359);
            this.groupBoxListeClients.TabIndex = 3;
            this.groupBoxListeClients.TabStop = false;
            this.groupBoxListeClients.Text = "Liste des Clients";
            // 
            // dataGridView_clients
            // 
            this.dataGridView_clients.AllowUserToAddRows = false;
            this.dataGridView_clients.AllowUserToDeleteRows = false;
            this.dataGridView_clients.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView_clients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_clients.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_clients.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView_clients.Location = new System.Drawing.Point(4, 23);
            this.dataGridView_clients.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView_clients.Name = "dataGridView_clients";
            this.dataGridView_clients.ReadOnly = true;
            this.dataGridView_clients.RowHeadersWidth = 51;
            this.dataGridView_clients.RowTemplate.Height = 24;
            this.dataGridView_clients.Size = new System.Drawing.Size(466, 332);
            this.dataGridView_clients.TabIndex = 38;
            // 
            // GestionClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 630);
            this.Controls.Add(this.groupBoxListeClients);
            this.Controls.Add(this.groupBoxActions);
            this.Controls.Add(this.groupBoxInfoClient);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(880, 493);
            this.Name = "GestionClients";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion des Clients";
            this.Load += new System.EventHandler(this.GestionClients_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBoxInfoClient.ResumeLayout(false);
            this.groupBoxInfoClient.PerformLayout();
            this.groupBoxActions.ResumeLayout(false);
            this.groupBoxListeClients.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_clients)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_id_client;
        private System.Windows.Forms.TextBox txt_nom_client;
        private System.Windows.Forms.TextBox txt_prenom_client;
        private System.Windows.Forms.TextBox txt_adresse;
        private System.Windows.Forms.TextBox txt_telephone;
        private System.Windows.Forms.Button btn_retour;
        private System.Windows.Forms.Button btn_ajouter;
        private System.Windows.Forms.Button btn_modifier;
        private System.Windows.Forms.Button btn_supprimer;
        private System.Windows.Forms.DataGridView dataGridView_clients;
        private System.Windows.Forms.GroupBox groupBoxInfoClient;
        private System.Windows.Forms.GroupBox groupBoxActions;
        private System.Windows.Forms.GroupBox groupBoxListeClients;
    }
}