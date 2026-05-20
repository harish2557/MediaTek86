using MediaTek86.controleur;
using MediaTek86.modele.metier;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MediaTek86.vue
{
    public partial class FrmAbsence : Form
    {
        private ControleurAbsence controleur;

        private int idPersonnel;

        public FrmAbsence(int idPersonnel)
        {
            InitializeComponent();

            this.idPersonnel =
                idPersonnel;

            controleur =
                new ControleurAbsence();

            ChargerLesAbsences();
        }

        private void ChargerLesAbsences()
        {
            List<Absence> lesAbsences =
                controleur.GetLesAbsences(
                    idPersonnel
                );

            dgvAbsence.Rows.Clear();

            foreach (Absence absence
                in lesAbsences)
            {
                dgvAbsence.Rows.Add(
                    absence.DateDebut
                        .ToShortDateString(),

                    absence.DateFin
                        .ToShortDateString(),

                    absence.IdMotif
                );
            }
        }

        private void btnAjouter_Click(
            object sender,
            EventArgs e)
        {
            FrmAjoutAbsence frm =
                new FrmAjoutAbsence(
                    idPersonnel
                );

            frm.ShowDialog();

            ChargerLesAbsences();
        }

        private void btnSupprimer_Click(
            object sender,
            EventArgs e)
        {
            if (dgvAbsence.CurrentRow != null)
            {
                string dateDebut =
                    dgvAbsence.CurrentRow
                    .Cells["colDateDebut"]
                    .Value
                    .ToString();

                DialogResult resultat =
                    MessageBox.Show(
                        "Supprimer cette absence ?",
                        "Suppression",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                    );

                if (resultat ==
                    DialogResult.Yes)
                {
                    controleur.DeleteAbsence(
                        idPersonnel,

                        Convert.ToDateTime(
                            dateDebut
                        ).ToString("yyyy-MM-dd")
                    );

                    ChargerLesAbsences();
                }
            }
        }

        private void btnModifier_Click(
            object sender,
            EventArgs e)
        {
            if (dgvAbsence.CurrentRow != null)
            {
                Absence absence =
                    new Absence(
                        idPersonnel,

                        Convert.ToDateTime(
                            dgvAbsence.CurrentRow
                            .Cells["colDateDebut"]
                            .Value
                        ),

                        Convert.ToDateTime(
                            dgvAbsence.CurrentRow
                            .Cells["colDateFin"]
                            .Value
                        ),

                        Convert.ToInt32(
                            dgvAbsence.CurrentRow
                            .Cells["colMotif"]
                            .Value
                        )
                    );

                FrmAjoutAbsence frm =
                    new FrmAjoutAbsence(
                        idPersonnel,
                        absence
                    );

                frm.ShowDialog();

                ChargerLesAbsences();
            }
        }
    }
}