using MediaTek86.controleur;
using MediaTek86.modele.metier;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MediaTek86.vue
{
    public partial class FrmAjoutPersonnel : Form
    {
        private ControleurPersonnel controleur;

        private int idPersonnel = 0;

        public FrmAjoutPersonnel()
        {
            InitializeComponent();

            controleur =
                new ControleurPersonnel();
        }

        public FrmAjoutPersonnel(Personnel personnel)
        {
            InitializeComponent();

            controleur =
                new ControleurPersonnel();

            idPersonnel =
                personnel.Id;

            txtNom.Text =
                personnel.Nom;

            txtPrenom.Text =
                personnel.Prenom;

            txtService.Text =
                personnel.IdService.ToString();
        }

        private void btnValider_Click(
            object sender,
            EventArgs e)
        {
            Personnel personnel =
                new Personnel(
                    idPersonnel,
                    txtNom.Text,
                    txtPrenom.Text,
                    int.Parse(txtService.Text)
                );

            if (idPersonnel == 0)
            {
                controleur.AddPersonnel(personnel);

                MessageBox.Show(
                    "Personnel ajouté"
                );
            }
            else
            {
                controleur.UpdatePersonnel(personnel);

                MessageBox.Show(
                    "Personnel modifié"
                );
            }

            this.Close();
        }
    }
}