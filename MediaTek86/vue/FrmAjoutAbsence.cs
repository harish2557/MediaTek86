using MediaTek86.controleur;
using MediaTek86.modele.metier;
using System;
using System.Windows.Forms;

namespace MediaTek86.vue
{
    public partial class FrmAjoutAbsence : Form
    {
        private ControleurAbsence controleur;

        private int idPersonnel;

        private string ancienneDate = "";

        public FrmAjoutAbsence(
            int idPersonnel)
        {
            InitializeComponent();

            this.idPersonnel =
                idPersonnel;

            controleur =
                new ControleurAbsence();
        }

        public FrmAjoutAbsence(
            int idPersonnel,
            Absence absence)
            : this(idPersonnel)
        {
            dtpDateDebut.Value =
                absence.DateDebut;

            dtpDateFin.Value =
                absence.DateFin;

            cbxMotif.Text =
                absence.IdMotif
                    .ToString();

            ancienneDate =
                absence.DateDebut
                    .ToString("yyyy-MM-dd");
        }

        private void btnValider_Click(
            object sender,
            EventArgs e)
        {
            Absence absence =
                new Absence(
                    idPersonnel,
                    dtpDateDebut.Value,
                    dtpDateFin.Value,

                    Convert.ToInt32(
                        cbxMotif.Text
                    )
                );

            if (ancienneDate == "")
            {
                controleur.AddAbsence(
                    absence
                );

                MessageBox.Show(
                    "Absence ajoutée"
                );
            }
            else
            {
                controleur.UpdateAbsence(
                    idPersonnel,
                    ancienneDate,
                    absence
                );

                MessageBox.Show(
                    "Absence modifiée"
                );
            }

            this.Close();
        }
    }
}