namespace MediaTek86.vue
{
    partial class FrmAjoutPersonnel
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        private void InitializeComponent()
        {
            this.labelNom = new System.Windows.Forms.Label();
            this.labelPrenom = new System.Windows.Forms.Label();
            this.labelService = new System.Windows.Forms.Label();

            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.txtService = new System.Windows.Forms.TextBox();

            this.btnValider = new System.Windows.Forms.Button();

            this.SuspendLayout();

            // 
            // labelNom
            // 
            this.labelNom.AutoSize = true;
            this.labelNom.Location = new System.Drawing.Point(220, 140);
            this.labelNom.Name = "labelNom";
            this.labelNom.Size = new System.Drawing.Size(29, 13);
            this.labelNom.TabIndex = 0;
            this.labelNom.Text = "Nom";

            // 
            // labelPrenom
            // 
            this.labelPrenom.AutoSize = true;
            this.labelPrenom.Location = new System.Drawing.Point(220, 190);
            this.labelPrenom.Name = "labelPrenom";
            this.labelPrenom.Size = new System.Drawing.Size(49, 13);
            this.labelPrenom.TabIndex = 1;
            this.labelPrenom.Text = "Prénom";

            // 
            // labelService
            // 
            this.labelService.AutoSize = true;
            this.labelService.Location = new System.Drawing.Point(220, 240);
            this.labelService.Name = "labelService";
            this.labelService.Size = new System.Drawing.Size(43, 13);
            this.labelService.TabIndex = 2;
            this.labelService.Text = "Service";

            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(320, 137);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(120, 20);
            this.txtNom.TabIndex = 3;

            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(320, 187);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(120, 20);
            this.txtPrenom.TabIndex = 4;

            // 
            // txtService
            // 
            this.txtService.Location = new System.Drawing.Point(320, 237);
            this.txtService.Name = "txtService";
            this.txtService.Size = new System.Drawing.Size(120, 20);
            this.txtService.TabIndex = 5;

            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(335, 290);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(90, 30);
            this.btnValider.TabIndex = 6;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);

            // 
            // FrmAjoutPersonnel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);

            this.Controls.Add(this.labelNom);
            this.Controls.Add(this.labelPrenom);
            this.Controls.Add(this.labelService);

            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.txtPrenom);
            this.Controls.Add(this.txtService);

            this.Controls.Add(this.btnValider);

            this.Name = "FrmAjoutPersonnel";
            this.Text = "Ajout d'un personnel";

            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label labelNom;
        private System.Windows.Forms.Label labelPrenom;
        private System.Windows.Forms.Label labelService;

        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.TextBox txtService;

        private System.Windows.Forms.Button btnValider;
    }
}