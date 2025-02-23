using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_medicale.view
{
    public partial class frmDemandeRDV : Form
    {
        public frmDemandeRDV()
        {
            InitializeComponent();
            //InitializeCustomComponents();

        }

        /// <summary>
        /// Initialise les composants personnalisés.
        /// </summary>
        /*private void InitializeCustomComponents()
        {
            soin = new Dictionary<string, decimal>
            {
                { "Consultation", 5000 },
                { "Vaccination", 3000 },
                { "Examen médical", 15000 },
                { "Bilan de santé", 50000 }
            };

            cmbSoin.Items.AddRange(soin.Keys.ToArray());
            if (cmbSoin.Items.Count > 0)
                cmbSoin.SelectedIndex = 0;

            UpdateCost();
        }*/

        private void frmDemandeRDV_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void rb1030_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
