using System;
using System.Drawing;
using System.Windows.Forms;
using Gestion_medicale.View;

namespace Gestion_medicale
{
    public partial class frmMDI : Form
    {
        public frmMDI()
        {
            InitializeComponent();
        }

        private void seDeconnecterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConnexion f = new frmConnexion();
            f.Show();
            this.Close();
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void fermer()
        {
            Form[] charr = this.MdiChildren;
            //For each child form set the window state to Maximized
            foreach (Form chform in charr)
            {
                chform.WindowState= FormWindowState.Maximized;
                chform.Close();
            }
        }

       /* private void frmMDI_Load(object sender, EventArgs e)
        {
            Computer myComputer = new Computer();
            this.Width = myComputer.Screen.Bounds.Width;
            this.Height = myComputer.Screen.Bounds.Height;
            this.Location = new Point(0,0);

        }
       */
        private void rougeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fermer();
            frmPatient f = new frmPatient();
            f.MdiParent = this;
            f.Show();
            f.WindowState = FormWindowState.Maximized;
        }

        private void bleuToolStripMenuItem_Click(object sender, EventArgs e)
        {

            fermer();
            frmMedecin f = new frmMedecin();
            f.MdiParent = this;
            f.Show();
            f.WindowState = FormWindowState.Maximized;
        }

        private void rendezvousToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fermer();
            frmRendezVous f = new frmRendezVous();
            f.MdiParent = this;
            f.Show();
            f.WindowState= FormWindowState.Maximized;
        }
    }
}
