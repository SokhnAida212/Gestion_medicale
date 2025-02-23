using System;
using System.Linq;
using System.Windows.Forms;
using Gestion_medicale.Data;
using Gestion_medicale.Model;

namespace Gestion_medicale.View
{
    public partial class frmPatient : Form
    {
        public frmPatient()
        {
            InitializeComponent();
        }

        BdRdvMedicalContext db = new BdRdvMedicalContext();

        private void ResetForm()
        {
            txtAdresse.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtGroupeSanguin.Text = string.Empty;
            txtNomPrenom.Text = string.Empty;
            txtPoids.Text = string.Empty;
            txtTaille.Text = string.Empty;
            txtTelephone.Text = string.Empty;
            dgPatient.DataSource = db.Patients.ToList();
            txtNomPrenom.Focus();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            try
            {
                // Vérification des entrées
                if (string.IsNullOrWhiteSpace(txtNomPrenom.Text) ||
                    string.IsNullOrWhiteSpace(txtTelephone.Text))
                {
                    MessageBox.Show("Veuillez remplir tous les champs obligatoires.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Patient p = new Patient
                {
                    NomPrenom = txtNomPrenom.Text,
                    Adresse = txtAdresse.Text,
                    Tel = txtTelephone.Text,
                    Email = txtEmail.Text,
                    GroupeSanguin = txtGroupeSanguin.Text
                };

                if (float.TryParse(txtPoids.Text, out float poids))
                    p.Poids = poids;
                else
                    MessageBox.Show("Poids invalide.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);

                if (float.TryParse(txtTaille.Text, out float taille))
                    p.Taille = taille;
                else
                    MessageBox.Show("Taille invalide.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);

                db.Patients.Add(p);
                db.SaveChanges();
                ResetForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmPatient_Load(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void btnChoisir_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgPatient.CurrentRow != null)
                {
                    txtNomPrenom.Text = dgPatient.CurrentRow.Cells["NomPrenom"].Value.ToString();
                    txtAdresse.Text = dgPatient.CurrentRow.Cells["Adresse"].Value.ToString();
                    txtEmail.Text = dgPatient.CurrentRow.Cells["Email"].Value.ToString();
                    txtTelephone.Text = dgPatient.CurrentRow.Cells["Tel"].Value.ToString();
                    txtGroupeSanguin.Text = dgPatient.CurrentRow.Cells["GroupeSanguin"].Value.ToString();
                    txtPoids.Text = dgPatient.CurrentRow.Cells["Poids"].Value.ToString();
                    txtTaille.Text = dgPatient.CurrentRow.Cells["Taille"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgPatient.CurrentRow == null)
                {
                    MessageBox.Show("Veuillez sélectionner un patient à modifier.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (int.TryParse(dgPatient.CurrentRow.Cells["Id"].Value.ToString(), out int id))
                {
                    var p = db.Patients.Find(id);
                    if (p != null)
                    {
                        p.NomPrenom = txtNomPrenom.Text;
                        p.Adresse = txtAdresse.Text;
                        p.Tel = txtTelephone.Text;
                        p.Email = txtEmail.Text;
                        p.GroupeSanguin = txtGroupeSanguin.Text;

                        if (float.TryParse(txtPoids.Text, out float poids))
                            p.Poids = poids;
                        else
                            MessageBox.Show("Poids invalide.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        if (float.TryParse(txtTaille.Text, out float taille))
                            p.Taille = taille;
                        else
                            MessageBox.Show("Taille invalide.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        db.SaveChanges();
                        ResetForm();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgPatient.CurrentRow == null)
                {
                    MessageBox.Show("Veuillez sélectionner un patient à supprimer.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (int.TryParse(dgPatient.CurrentRow.Cells["Id"].Value.ToString(), out int id))
                {
                    var p = db.Patients.Find(id);
                    if (p != null)
                    {
                        db.Patients.Remove(p);
                        db.SaveChanges();
                        ResetForm();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}