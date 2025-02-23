namespace Gestion_medicale.view
{
    partial class frmDemandeRDV
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnValider = new System.Windows.Forms.Button();
            this.cmbSoin = new System.Windows.Forms.ComboBox();
            this.cmbModePaiement = new System.Windows.Forms.ComboBox();
            this.lblDoctorInfo = new System.Windows.Forms.Label();
            this.lblSoin = new System.Windows.Forms.Label();
            this.lblCout = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblPatientInfo = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.txtReferencePaiement = new System.Windows.Forms.TextBox();
            this.txtCout = new System.Windows.Forms.TextBox();
            this.txtNomPrenom = new System.Windows.Forms.TextBox();
            this.lblReferencePaiement = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.lblNomPrenom = new System.Windows.Forms.Label();
            this.lblGenre = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.cmbGenre = new System.Windows.Forms.ComboBox();
            this.grpHoraires = new System.Windows.Forms.GroupBox();
            this.rb0830 = new System.Windows.Forms.RadioButton();
            this.rb0930 = new System.Windows.Forms.RadioButton();
            this.rb1030 = new System.Windows.Forms.RadioButton();
            this.rb1130 = new System.Windows.Forms.RadioButton();
            this.rb1230 = new System.Windows.Forms.RadioButton();
            this.rb1630 = new System.Windows.Forms.RadioButton();
            this.rb1530 = new System.Windows.Forms.RadioButton();
            this.rb13 = new System.Windows.Forms.RadioButton();
            this.grpHoraires.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(32, 628);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(75, 32);
            this.btnValider.TabIndex = 0;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            // 
            // cmbSoin
            // 
            this.cmbSoin.FormattingEnabled = true;
            this.cmbSoin.Location = new System.Drawing.Point(177, 102);
            this.cmbSoin.Name = "cmbSoin";
            this.cmbSoin.Size = new System.Drawing.Size(121, 28);
            this.cmbSoin.TabIndex = 1;
            // 
            // cmbModePaiement
            // 
            this.cmbModePaiement.FormattingEnabled = true;
            this.cmbModePaiement.Items.AddRange(new object[] {
            "Espèces",
            "Carte Bancaire ",
            "Chèque",
            "Wave",
            "Orange Money"});
            this.cmbModePaiement.Location = new System.Drawing.Point(177, 485);
            this.cmbModePaiement.Name = "cmbModePaiement";
            this.cmbModePaiement.Size = new System.Drawing.Size(121, 28);
            this.cmbModePaiement.TabIndex = 2;
            // 
            // lblDoctorInfo
            // 
            this.lblDoctorInfo.AutoSize = true;
            this.lblDoctorInfo.Location = new System.Drawing.Point(37, 45);
            this.lblDoctorInfo.Name = "lblDoctorInfo";
            this.lblDoctorInfo.Size = new System.Drawing.Size(70, 20);
            this.lblDoctorInfo.TabIndex = 3;
            this.lblDoctorInfo.Text = "Docteur ";
            // 
            // lblSoin
            // 
            this.lblSoin.AutoSize = true;
            this.lblSoin.Location = new System.Drawing.Point(37, 110);
            this.lblSoin.Name = "lblSoin";
            this.lblSoin.Size = new System.Drawing.Size(41, 20);
            this.lblSoin.TabIndex = 4;
            this.lblSoin.Text = "Soin";
            this.lblSoin.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblCout
            // 
            this.lblCout.AutoSize = true;
            this.lblCout.Location = new System.Drawing.Point(37, 159);
            this.lblCout.Name = "lblCout";
            this.lblCout.Size = new System.Drawing.Size(47, 20);
            this.lblCout.TabIndex = 5;
            this.lblCout.Text = "Coût ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 485);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Mode Paiement";
            // 
            // lblPatientInfo
            // 
            this.lblPatientInfo.AutoSize = true;
            this.lblPatientInfo.Location = new System.Drawing.Point(37, 225);
            this.lblPatientInfo.Name = "lblPatientInfo";
            this.lblPatientInfo.Size = new System.Drawing.Size(174, 20);
            this.lblPatientInfo.TabIndex = 7;
            this.lblPatientInfo.Text = "Informations du Patient";
            this.lblPatientInfo.Click += new System.EventHandler(this.label5_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(177, 39);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 26);
            this.textBox1.TabIndex = 8;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(177, 560);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 26);
            this.textBox4.TabIndex = 11;
            // 
            // txtReferencePaiement
            // 
            this.txtReferencePaiement.Location = new System.Drawing.Point(177, 528);
            this.txtReferencePaiement.Name = "txtReferencePaiement";
            this.txtReferencePaiement.Size = new System.Drawing.Size(100, 26);
            this.txtReferencePaiement.TabIndex = 12;
            // 
            // txtCout
            // 
            this.txtCout.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtCout.Location = new System.Drawing.Point(177, 152);
            this.txtCout.Name = "txtCout";
            this.txtCout.ReadOnly = true;
            this.txtCout.Size = new System.Drawing.Size(100, 26);
            this.txtCout.TabIndex = 13;
            // 
            // txtNomPrenom
            // 
            this.txtNomPrenom.Location = new System.Drawing.Point(177, 273);
            this.txtNomPrenom.Name = "txtNomPrenom";
            this.txtNomPrenom.Size = new System.Drawing.Size(100, 26);
            this.txtNomPrenom.TabIndex = 14;
            // 
            // lblReferencePaiement
            // 
            this.lblReferencePaiement.AutoSize = true;
            this.lblReferencePaiement.Location = new System.Drawing.Point(11, 528);
            this.lblReferencePaiement.Name = "lblReferencePaiement";
            this.lblReferencePaiement.Size = new System.Drawing.Size(154, 20);
            this.lblReferencePaiement.TabIndex = 15;
            this.lblReferencePaiement.Text = "Référence paiement";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 566);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "Numéro Reçu";
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(253, 628);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(75, 32);
            this.btnAnnuler.TabIndex = 17;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(150, 628);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 32);
            this.button3.TabIndex = 18;
            this.button3.Text = "Valider";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // lblNomPrenom
            // 
            this.lblNomPrenom.AutoSize = true;
            this.lblNomPrenom.Location = new System.Drawing.Point(41, 273);
            this.lblNomPrenom.Name = "lblNomPrenom";
            this.lblNomPrenom.Size = new System.Drawing.Size(105, 20);
            this.lblNomPrenom.TabIndex = 19;
            this.lblNomPrenom.Text = "Nom  Prénom";
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.Location = new System.Drawing.Point(41, 326);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(54, 20);
            this.lblGenre.TabIndex = 20;
            this.lblGenre.Text = "Genre";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(37, 378);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(38, 20);
            this.lblAge.TabIndex = 21;
            this.lblAge.Text = "Age";
            this.lblAge.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(177, 372);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(100, 26);
            this.txtAge.TabIndex = 26;
            // 
            // cmbGenre
            // 
            this.cmbGenre.FormattingEnabled = true;
            this.cmbGenre.Items.AddRange(new object[] {
            "Masculin",
            "Féminin"});
            this.cmbGenre.Location = new System.Drawing.Point(177, 323);
            this.cmbGenre.Name = "cmbGenre";
            this.cmbGenre.Size = new System.Drawing.Size(121, 28);
            this.cmbGenre.TabIndex = 27;
            // 
            // grpHoraires
            // 
            this.grpHoraires.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grpHoraires.Controls.Add(this.rb13);
            this.grpHoraires.Controls.Add(this.rb1530);
            this.grpHoraires.Controls.Add(this.rb1630);
            this.grpHoraires.Controls.Add(this.rb1230);
            this.grpHoraires.Controls.Add(this.rb1130);
            this.grpHoraires.Controls.Add(this.rb1030);
            this.grpHoraires.Controls.Add(this.rb0930);
            this.grpHoraires.Controls.Add(this.rb0830);
            this.grpHoraires.Location = new System.Drawing.Point(408, 45);
            this.grpHoraires.Name = "grpHoraires";
            this.grpHoraires.Size = new System.Drawing.Size(292, 492);
            this.grpHoraires.TabIndex = 28;
            this.grpHoraires.TabStop = false;
            this.grpHoraires.Text = "Choisissez un horaire";
            this.grpHoraires.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // rb0830
            // 
            this.rb0830.AutoSize = true;
            this.rb0830.Location = new System.Drawing.Point(7, 44);
            this.rb0830.Name = "rb0830";
            this.rb0830.Size = new System.Drawing.Size(122, 24);
            this.rb0830.TabIndex = 0;
            this.rb0830.TabStop = true;
            this.rb0830.Text = "08:00  08:30";
            this.rb0830.UseVisualStyleBackColor = true;
            // 
            // rb0930
            // 
            this.rb0930.AutoSize = true;
            this.rb0930.Location = new System.Drawing.Point(7, 109);
            this.rb0930.Name = "rb0930";
            this.rb0930.Size = new System.Drawing.Size(128, 24);
            this.rb0930.TabIndex = 1;
            this.rb0930.TabStop = true;
            this.rb0930.Text = "09h00 09h30";
            this.rb0930.UseVisualStyleBackColor = true;
            // 
            // rb1030
            // 
            this.rb1030.AutoSize = true;
            this.rb1030.Location = new System.Drawing.Point(7, 175);
            this.rb1030.Name = "rb1030";
            this.rb1030.Size = new System.Drawing.Size(132, 24);
            this.rb1030.TabIndex = 2;
            this.rb1030.TabStop = true;
            this.rb1030.Text = "10h00  10h30";
            this.rb1030.UseVisualStyleBackColor = true;
            this.rb1030.CheckedChanged += new System.EventHandler(this.rb1030_CheckedChanged);
            // 
            // rb1130
            // 
            this.rb1130.AutoSize = true;
            this.rb1130.Location = new System.Drawing.Point(0, 229);
            this.rb1130.Name = "rb1130";
            this.rb1130.Size = new System.Drawing.Size(128, 24);
            this.rb1130.TabIndex = 3;
            this.rb1130.TabStop = true;
            this.rb1130.Text = "11h00 11h30";
            this.rb1130.UseVisualStyleBackColor = true;
            this.rb1130.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // rb1230
            // 
            this.rb1230.AutoSize = true;
            this.rb1230.Location = new System.Drawing.Point(7, 284);
            this.rb1230.Name = "rb1230";
            this.rb1230.Size = new System.Drawing.Size(128, 24);
            this.rb1230.TabIndex = 4;
            this.rb1230.TabStop = true;
            this.rb1230.Text = "12h00 12h30";
            this.rb1230.UseVisualStyleBackColor = true;
            // 
            // rb1630
            // 
            this.rb1630.AutoSize = true;
            this.rb1630.Location = new System.Drawing.Point(11, 436);
            this.rb1630.Name = "rb1630";
            this.rb1630.Size = new System.Drawing.Size(128, 24);
            this.rb1630.TabIndex = 5;
            this.rb1630.TabStop = true;
            this.rb1630.Text = "16h00 16h30";
            this.rb1630.UseVisualStyleBackColor = true;
            // 
            // rb1530
            // 
            this.rb1530.AutoSize = true;
            this.rb1530.Location = new System.Drawing.Point(11, 378);
            this.rb1530.Name = "rb1530";
            this.rb1530.Size = new System.Drawing.Size(128, 24);
            this.rb1530.TabIndex = 6;
            this.rb1530.TabStop = true;
            this.rb1530.Text = "15h00 15h30";
            this.rb1530.UseVisualStyleBackColor = true;
            // 
            // rb13
            // 
            this.rb13.AutoSize = true;
            this.rb13.Location = new System.Drawing.Point(11, 333);
            this.rb13.Name = "rb13";
            this.rb13.Size = new System.Drawing.Size(83, 24);
            this.rb13.TabIndex = 7;
            this.rb13.TabStop = true;
            this.rb13.Text = "13h00 ";
            this.rb13.UseVisualStyleBackColor = true;
            // 
            // frmDemandeRDV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 672);
            this.Controls.Add(this.grpHoraires);
            this.Controls.Add(this.cmbGenre);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.lblGenre);
            this.Controls.Add(this.lblNomPrenom);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblReferencePaiement);
            this.Controls.Add(this.txtNomPrenom);
            this.Controls.Add(this.txtCout);
            this.Controls.Add(this.txtReferencePaiement);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblPatientInfo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblCout);
            this.Controls.Add(this.lblSoin);
            this.Controls.Add(this.lblDoctorInfo);
            this.Controls.Add(this.cmbModePaiement);
            this.Controls.Add(this.cmbSoin);
            this.Controls.Add(this.btnValider);
            this.Name = "frmDemandeRDV";
            this.Text = "frmDemandeRDV";
            this.Load += new System.EventHandler(this.frmDemandeRDV_Load);
            this.grpHoraires.ResumeLayout(false);
            this.grpHoraires.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.ComboBox cmbSoin;
        private System.Windows.Forms.ComboBox cmbModePaiement;
        private System.Windows.Forms.Label lblDoctorInfo;
        private System.Windows.Forms.Label lblSoin;
        private System.Windows.Forms.Label lblCout;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblPatientInfo;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox txtReferencePaiement;
        private System.Windows.Forms.TextBox txtCout;
        private System.Windows.Forms.TextBox txtNomPrenom;
        private System.Windows.Forms.Label lblReferencePaiement;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label lblNomPrenom;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.ComboBox cmbGenre;
        private System.Windows.Forms.GroupBox grpHoraires;
        private System.Windows.Forms.RadioButton rb1230;
        private System.Windows.Forms.RadioButton rb1130;
        private System.Windows.Forms.RadioButton rb1030;
        private System.Windows.Forms.RadioButton rb0930;
        private System.Windows.Forms.RadioButton rb0830;
        private System.Windows.Forms.RadioButton rb13;
        private System.Windows.Forms.RadioButton rb1530;
        private System.Windows.Forms.RadioButton rb1630;

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmDemandeRDV
            // 
            this.ClientSize = new System.Drawing.Size(278, 244);
            this.Name = "frmDemandeRDV";
            this.Load += new System.EventHandler(this.frmDemandeRDV_Load_1);
            this.ResumeLayout(false);

        }
    }
}