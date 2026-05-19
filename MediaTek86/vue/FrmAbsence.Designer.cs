namespace MediaTek86.vue
{
    partial class FrmAbsence
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
            this.dgvAbsence = new System.Windows.Forms.DataGridView();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.idabsence = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datedebut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datefin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.motif = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAbsence)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAbsence
            // 
            this.dgvAbsence.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAbsence.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idabsence,
            this.datedebut,
            this.datefin,
            this.motif});
            this.dgvAbsence.Location = new System.Drawing.Point(132, 65);
            this.dgvAbsence.Name = "dgvAbsence";
            this.dgvAbsence.Size = new System.Drawing.Size(481, 258);
            this.dgvAbsence.TabIndex = 0;
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(174, 341);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(75, 23);
            this.btnAjouter.TabIndex = 1;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(469, 341);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(75, 23);
            this.btnSupprimer.TabIndex = 2;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(316, 341);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(75, 23);
            this.btnModifier.TabIndex = 3;
            this.btnModifier.Text = "modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            // 
            // idabsence
            // 
            this.idabsence.HeaderText = "ID";
            this.idabsence.Name = "idabsence";
            // 
            // datedebut
            // 
            this.datedebut.HeaderText = "Date début";
            this.datedebut.Name = "datedebut";
            // 
            // datefin
            // 
            this.datefin.HeaderText = "Date fin";
            this.datefin.Name = "datefin";
            // 
            // motif
            // 
            this.motif.HeaderText = "Motif";
            this.motif.Name = "motif";
            // 
            // FrmAbsence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.dgvAbsence);
            this.Name = "FrmAbsence";
            this.Text = "FrmAbsence";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAbsence)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAbsence;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.DataGridViewTextBoxColumn idabsence;
        private System.Windows.Forms.DataGridViewTextBoxColumn datedebut;
        private System.Windows.Forms.DataGridViewTextBoxColumn datefin;
        private System.Windows.Forms.DataGridViewTextBoxColumn motif;
    }
}