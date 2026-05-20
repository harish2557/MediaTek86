using MediaTek86.controleur;
using MediaTek86.modele.metier;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MediaTek86.vue
{
    public partial class FrmPersonnel : Form
    {
        private ControleurPersonnel controleur;

        public FrmPersonnel()
        {
            InitializeComponent();

            controleur =
                new ControleurPersonnel();

            ChargerLesPersonnels();
        }

        private void ChargerLesPersonnels()
        {
            List<Personnel> lesPersonnels =
                controleur.GetLesPersonnels();

            dgvPersonnel.Rows.Clear();

            foreach (Personnel personnel in lesPersonnels)
            {
                dgvPersonnel.Rows.Add(
                    personnel.Id,
                    personnel.Nom,
                    personnel.Prenom,
                    personnel.IdService
                );
            }
        }

        private void Ajouter_Click(
            object sender,
            EventArgs e)
        {
            FrmAjoutPersonnel frm =
                new FrmAjoutPersonnel();

            frm.ShowDialog();

            ChargerLesPersonnels();
        }

        private void btnModifier_Click(
            object sender,
            EventArgs e)
        {
            if (dgvPersonnel.CurrentRow != null)
            {
                Personnel personnel =
                    new Personnel(
                        Convert.ToInt32(
                            dgvPersonnel.CurrentRow
                            .Cells["idpersonnel"]
                            .Value
                        ),

                        dgvPersonnel.CurrentRow
                        .Cells["nom"]
                        .Value
                        .ToString(),

                        dgvPersonnel.CurrentRow
                        .Cells["prenom"]
                        .Value
                        .ToString(),

                        Convert.ToInt32(
                            dgvPersonnel.CurrentRow
                            .Cells["service"]
                            .Value
                        )
                    );

                FrmAjoutPersonnel frm =
                    new FrmAjoutPersonnel(
                        personnel
                    );

                frm.ShowDialog();

                ChargerLesPersonnels();
            }
        }

        private void button3_Click(
            object sender,
            EventArgs e)
        {
            if (dgvPersonnel.CurrentRow != null)
            {
                int idPersonnel =
                    Convert.ToInt32(
                        dgvPersonnel.CurrentRow
                        .Cells["idpersonnel"]
                        .Value
                    );

                DialogResult resultat =
                    MessageBox.Show(
                        "Voulez-vous supprimer ce personnel ?",
                        "Suppression",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                    );

                if (resultat ==
                    DialogResult.Yes)
                {
                    controleur.DeletePersonnel(
                        idPersonnel
                    );

                    ChargerLesPersonnels();
                }
            }
        }

        private void btnAbsence_Click(
            object sender,
            EventArgs e)
        {
            if (dgvPersonnel.CurrentRow != null)
            {
                int idPersonnel =
                    Convert.ToInt32(
                        dgvPersonnel.CurrentRow
                        .Cells["idpersonnel"]
                        .Value
                    );

                FrmAbsence frm =
                    new FrmAbsence(
                        idPersonnel
                    );

                frm.ShowDialog();
            }
        }

        private void dataGridView1_CellContentClick(
            object sender,
            DataGridViewCellEventArgs e)
        {

        }
    }
}