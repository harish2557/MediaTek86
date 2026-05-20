namespace MediaTek86.vue
{
    partial class FrmAbsence
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(
            bool disposing)
        {
            if (disposing &&
                (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.dgvAbsence =
                new System.Windows.Forms.DataGridView();

            this.colDateDebut =
                new System.Windows.Forms.DataGridViewTextBoxColumn();

            this.colDateFin =
                new System.Windows.Forms.DataGridViewTextBoxColumn();

            this.colMotif =
                new System.Windows.Forms.DataGridViewTextBoxColumn();

            this.btnAjouter =
                new System.Windows.Forms.Button();

            this.btnModifier =
                new System.Windows.Forms.Button();

            this.btnSupprimer =
                new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)
                (this.dgvAbsence)).BeginInit();

            this.SuspendLayout();

            // dgvAbsence

            this.dgvAbsence.ColumnHeadersHeightSizeMode =
                System.Windows.Forms
                .DataGridViewColumnHeadersHeightSizeMode
                .AutoSize;

            this.dgvAbsence.Columns.AddRange(
                new System.Windows.Forms
                .DataGridViewColumn[]
            {
                this.colDateDebut,
                this.colDateFin,
                this.colMotif
            });

            this.dgvAbsence.Location =
                new System.Drawing.Point(
                    78,
                    69
                );

            this.dgvAbsence.Name =
                "dgvAbsence";

            this.dgvAbsence.Size =
                new System.Drawing.Size(
                    500,
                    250
                );

            this.dgvAbsence.TabIndex = 0;

            // colDateDebut

            this.colDateDebut.HeaderText =
                "Date début";

            this.colDateDebut.Name =
                "colDateDebut";

            // colDateFin

            this.colDateFin.HeaderText =
                "Date fin";

            this.colDateFin.Name =
                "colDateFin";

            // colMotif

            this.colMotif.HeaderText =
                "Motif";

            this.colMotif.Name =
                "colMotif";

            // btnAjouter

            this.btnAjouter.Location =
                new System.Drawing.Point(
                    120,
                    360
                );

            this.btnAjouter.Name =
                "btnAjouter";

            this.btnAjouter.Size =
                new System.Drawing.Size(
                    75,
                    23
                );

            this.btnAjouter.TabIndex = 1;

            this.btnAjouter.Text =
                "Ajouter";

            this.btnAjouter.UseVisualStyleBackColor =
                true;

            this.btnAjouter.Click +=
                new System.EventHandler(
                    this.btnAjouter_Click
                );

            // btnModifier

            this.btnModifier.Location =
                new System.Drawing.Point(
                    280,
                    360
                );

            this.btnModifier.Name =
                "btnModifier";

            this.btnModifier.Size =
                new System.Drawing.Size(
                    75,
                    23
                );

            this.btnModifier.TabIndex = 2;

            this.btnModifier.Text =
                "Modifier";

            this.btnModifier.UseVisualStyleBackColor =
                true;

            this.btnModifier.Click +=
                new System.EventHandler(
                    this.btnModifier_Click
                );

            // btnSupprimer

            this.btnSupprimer.Location =
                new System.Drawing.Point(
                    440,
                    360
                );

            this.btnSupprimer.Name =
                "btnSupprimer";

            this.btnSupprimer.Size =
                new System.Drawing.Size(
                    75,
                    23
                );

            this.btnSupprimer.TabIndex = 3;

            this.btnSupprimer.Text =
                "Supprimer";

            this.btnSupprimer.UseVisualStyleBackColor =
                true;

            this.btnSupprimer.Click +=
                new System.EventHandler(
                    this.btnSupprimer_Click
                );

            // FrmAbsence

            this.AutoScaleDimensions =
                new System.Drawing.SizeF(
                    6F,
                    13F
                );

            this.AutoScaleMode =
                System.Windows.Forms
                .AutoScaleMode.Font;

            this.ClientSize =
                new System.Drawing.Size(
                    684,
                    461
                );

            this.Controls.Add(
                this.btnSupprimer
            );

            this.Controls.Add(
                this.btnModifier
            );

            this.Controls.Add(
                this.btnAjouter
            );

            this.Controls.Add(
                this.dgvAbsence
            );

            this.Name =
                "FrmAbsence";

            this.Text =
                "Gestion des absences";

            ((System.ComponentModel.ISupportInitialize)
                (this.dgvAbsence)).EndInit();

            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms
            .DataGridView dgvAbsence;

        private System.Windows.Forms
            .Button btnAjouter;

        private System.Windows.Forms
            .Button btnModifier;

        private System.Windows.Forms
            .Button btnSupprimer;

        private System.Windows.Forms
            .DataGridViewTextBoxColumn colDateDebut;

        private System.Windows.Forms
            .DataGridViewTextBoxColumn colDateFin;

        private System.Windows.Forms
            .DataGridViewTextBoxColumn colMotif;
    }
}