using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_medicale
{
    public partial class frmConnexion : Form
    {
        public frmConnexion()
        {
            InitializeComponent();
        }

        private void frmConnexion_Load(object sender, EventArgs e)
        {

        }

        private void lblMotDePasse_Click(object sender, EventArgs e)
        {

        }

        private void lblNomUtilisateur_Click(object sender, EventArgs e)
        {

        }

        private void txtNomUtlisateur_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMotDePasse_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSeConnecter_Click(object sender, EventArgs e)
        {
            frmMDI f = new frmMDI();
            f.Show();
            this.Hide();
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
