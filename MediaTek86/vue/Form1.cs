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

            controleur = new ControleurPersonnel();

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

        private void Ajouter_Click(object sender, EventArgs e)
        {
            FrmAjoutPersonnel frm =
                new FrmAjoutPersonnel();

            frm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(
            object sender,
            DataGridViewCellEventArgs e)
        {

        }
    }
}