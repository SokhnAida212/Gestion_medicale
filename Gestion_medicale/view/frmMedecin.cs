using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gestion_medicale.Data;
using Gestion_medicale.Model;

namespace Gestion_medicale.View
{
    public partial class frmMedecin : Form
    {
        BdRdvMedicalContext db = new BdRdvMedicalContext();
        public frmMedecin()
        {
            InitializeComponent();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            Medecins m=new Medecins();
            m.Adresse=txtAdresse.Text;
            m.NumeroOrdre=txtNumeroOrdre.Text;
            m.Email=txtEmail.Text;
            m.NomPrenom=txtNomPrenom.Text;
            m.Tel=txtTelephone.Text;
            //m.Specialite=txtSpecialite.Text;
            //m.Identifiant=txtIdentifiant.Text;
            //m.Statut=false;
            db.Medecins.Add(m);
            db.SaveChanges();
            ResetForm();
        }
        private void ResetForm()
        {
            txtAdresse.Text=string.Empty;
            txtEmail.Text=string.Empty;
            txtIdentifiant.Text=string.Empty;
            txtSpecialite.Text=string.Empty;
            txtTelephone.Text=string.Empty;
            txtNomPrenom.Text=string.Empty;
            txtNumeroOrdre.Text=string.Empty;
           // dgMedecin.DataSource=db.Medecins.Select(a=> new {a.IdU,a.NumeroOrdre,a.Identifiant,a.Specialite,a.NomPrenom,a.Tel,a.Email}).ToList();
            txtNomPrenom.Focus();  
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            int? id = int.Parse(dgMedecin.CurrentRow.Cells[0].Value.ToString());
            var m = db.Medecins.Find(id);
            m.Adresse = txtAdresse.Text;
            m.NumeroOrdre = txtNumeroOrdre.Text;
            m.Email = txtEmail.Text;
            m.NomPrenom = txtNomPrenom.Text;
            m.Tel = txtTelephone.Text;
            //m.Specialite = txtSpecialite.Text;
           // m.Identifiant = txtIdentifiant.Text;
            db.SaveChanges();
            ResetForm();
        }

        private void btnChoisir_Click(object sender, EventArgs e)
        {
            int? id = int.Parse(dgMedecin.CurrentRow.Cells[0].Value.ToString());
            var m = db.Medecins.Find(id);
            if (m != null)
            {
                txtAdresse.Text = m.Adresse;
                txtEmail.Text = m.Email;
                //txtIdentifiant.Text = m.Identifiant;
                txtNumeroOrdre.Text = m.NumeroOrdre;
                //txtSpecialite.Text = m.Specialite;
                txtTelephone.Text = m.Tel;
                txtNomPrenom.Text = m.NomPrenom;
            }
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            int? id = int.Parse(dgMedecin.CurrentRow.Cells[0].Value.ToString());
            var m = db.Medecins.Find(id);
            db.Medecins.Remove(m);
            db.SaveChanges();
            ResetForm();
        }

        private void frmMedecin_Load(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void btnAgenda_Click(object sender, EventArgs e)
        {
            frmAgenda a=new frmAgenda();
            a.idMedecin = int.Parse(dgMedecin.CurrentRow.Cells[0].Value.ToString());
            a.Show();
        }
    }
}
