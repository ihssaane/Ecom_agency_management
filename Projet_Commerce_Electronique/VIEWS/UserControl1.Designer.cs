namespace Projet_Commerce_Electronique.VIEWS
{
    partial class UserControl1
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.id_cat = new System.Windows.Forms.Label();
            this.nom_cat = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btn_ajouter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // id_cat
            // 
            this.id_cat.AutoSize = true;
            this.id_cat.Location = new System.Drawing.Point(37, 74);
            this.id_cat.Name = "id_cat";
            this.id_cat.Size = new System.Drawing.Size(82, 16);
            this.id_cat.TabIndex = 0;
            this.id_cat.Text = "id_categorie";
            this.id_cat.Click += new System.EventHandler(this.label1_Click);
            // 
            // nom_cat
            // 
            this.nom_cat.AutoSize = true;
            this.nom_cat.Location = new System.Drawing.Point(37, 113);
            this.nom_cat.Name = "nom_cat";
            this.nom_cat.Size = new System.Drawing.Size(58, 16);
            this.nom_cat.TabIndex = 1;
            this.nom_cat.Text = "nom_cat";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(175, 74);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(175, 122);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 3;
            // 
            // btn_ajouter
            // 
            this.btn_ajouter.Location = new System.Drawing.Point(49, 244);
            this.btn_ajouter.Name = "btn_ajouter";
            this.btn_ajouter.Size = new System.Drawing.Size(75, 23);
            this.btn_ajouter.TabIndex = 4;
            this.btn_ajouter.Text = "ajouter";
            this.btn_ajouter.UseVisualStyleBackColor = true;
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_ajouter);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.nom_cat);
            this.Controls.Add(this.id_cat);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(848, 405);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label id_cat;
        private System.Windows.Forms.Label nom_cat;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btn_ajouter;
    }
}
