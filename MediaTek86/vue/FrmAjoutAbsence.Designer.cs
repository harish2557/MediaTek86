namespace MediaTek86.vue
{
    partial class FrmAjoutAbsence
    {
        /// <summary>
        /// Variable du designer
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage
        /// </summary>
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

        #region Code généré par le Designer

        private void InitializeComponent()
        {
            this.label1 =
                new System.Windows.Forms.Label();

            this.label2 =
                new System.Windows.Forms.Label();

            this.label3 =
                new System.Windows.Forms.Label();

            this.dtpDateDebut =
                new System.Windows.Forms.DateTimePicker();

            this.dtpDateFin =
                new System.Windows.Forms.DateTimePicker();

            this.cbxMotif =
                new System.Windows.Forms.ComboBox();

            this.btnValider =
                new System.Windows.Forms.Button();

            this.SuspendLayout();

            // label1
            this.label1.AutoSize = true;
            this.label1.Location =
                new System.Drawing.Point(240, 150);

            this.label1.Name = "label1";
            this.label1.Size =
                new System.Drawing.Size(67, 13);

            this.label1.TabIndex = 0;
            this.label1.Text = "Date début";

            // label2
            this.label2.AutoSize = true;
            this.label2.Location =
                new System.Drawing.Point(240, 195);

            this.label2.Name = "label2";
            this.label2.Size =
                new System.Drawing.Size(50, 13);

            this.label2.TabIndex = 1;
            this.label2.Text = "Date fin";

            // label3
            this.label3.AutoSize = true;
            this.label3.Location =
                new System.Drawing.Point(240, 240);

            this.label3.Name = "label3";
            this.label3.Size =
                new System.Drawing.Size(30, 13);

            this.label3.TabIndex = 2;
            this.label3.Text = "Motif";

            // dtpDateDebut
            this.dtpDateDebut.Location =
                new System.Drawing.Point(343, 143);

            this.dtpDateDebut.Name =
                "dtpDateDebut";

            this.dtpDateDebut.Size =
                new System.Drawing.Size(200, 20);

            this.dtpDateDebut.TabIndex = 3;

            // dtpDateFin
            this.dtpDateFin.Location =
                new System.Drawing.Point(343, 188);

            this.dtpDateFin.Name =
                "dtpDateFin";

            this.dtpDateFin.Size =
                new System.Drawing.Size(200, 20);

            this.dtpDateFin.TabIndex = 4;

            // cbxMotif
            this.cbxMotif.FormattingEnabled = true;

            this.cbxMotif.Items.AddRange(
                new object[]
                {
                    "1",
                    "2",
                    "3",
                    "4"
                });

            this.cbxMotif.Location =
                new System.Drawing.Point(343, 237);

            this.cbxMotif.Name =
                "cbxMotif";

            this.cbxMotif.Size =
                new System.Drawing.Size(121, 21);

            this.cbxMotif.TabIndex = 5;

            // btnValider
            this.btnValider.Location =
                new System.Drawing.Point(343, 285);

            this.btnValider.Name =
                "btnValider";

            this.btnValider.Size =
                new System.Drawing.Size(75, 23);

            this.btnValider.TabIndex = 6;

            this.btnValider.Text =
                "Valider";

            this.btnValider.UseVisualStyleBackColor =
                true;

            this.btnValider.Click +=
                new System.EventHandler(
                    this.btnValider_Click
                );

            // FrmAjoutAbsence
            this.AutoScaleDimensions =
                new System.Drawing.SizeF(6F, 13F);

            this.AutoScaleMode =
                System.Windows.Forms.AutoScaleMode.Font;

            this.ClientSize =
                new System.Drawing.Size(800, 450);

            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.cbxMotif);
            this.Controls.Add(this.dtpDateFin);
            this.Controls.Add(this.dtpDateDebut);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);

            this.Name =
                "FrmAjoutAbsence";

            this.Text =
                "Ajout absence";

            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.DateTimePicker dtpDateDebut;
        private System.Windows.Forms.DateTimePicker dtpDateFin;

        private System.Windows.Forms.ComboBox cbxMotif;

        private System.Windows.Forms.Button btnValider;
    }
}