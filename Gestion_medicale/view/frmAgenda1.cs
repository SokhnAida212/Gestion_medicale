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
    public partial class frmAgenda : Form
    {
        public int idMedecin;
        public frmAgenda()
        {
            InitializeComponent();
        }
        BdRdvMedicalContext db=new BdRdvMedicalContext();
        private void frmAgenda_Load(object sender, EventArgs e)
        {
            var m=db.Medecins.Find(idMedecin);
            lblMedecin.Text = string.Format("N Ordre: {0},Nom prenom: {1}", m.NumeroOrdre, m.NomPrenom);
            lblIdMedecin.Text=m.IdU.ToString();
            lblIdMedecin.Visible=false;
            ResetForrm();
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            Agenda a=new Agenda();
            a.Creneau = int.Parse(txtCreneau.Text);
            a.HeureFin=txtHeureFin.Text;
            a.HeureDebut=txtHeureDebut.Text;
            a.IdMedecin = idMedecin;
            a.DatePlanifie=txtDateAgenda.Value;
            a.Statut = "Brouillon";
            a.Lieu= txtLieu.Text;
            a.Titre= txtTitre.Text;
            //db.Agenda.Add(a);
            db.SaveChanges();
            ResetForrm();
        }
        private void  ResetForrm()
        {
            //dgAgenda.DataSource = db.Agenda.Where(a=>a.DatePlanifie>=DateTime.Now && a.IdMedecin==idMedecin).ToList();
            txtCreneau.Text=string.Empty;
            txtDateAgenda.Value = DateTime.Now;
            txtHeureDebut.Text = string.Empty;
            txtHeureFin.Text = string.Empty;
            txtLieu.Text = string.Empty;
            txtTitre.Text = string.Empty;
            txtTitre.Focus();

        }
    }
}
