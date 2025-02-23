namespace Gestion_medicale.View
{
    partial class frmPatient
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
            this.dgPatient = new System.Windows.Forms.DataGridView();
            this.lblNomPrenom = new System.Windows.Forms.Label();
            this.txtNomPrenom = new System.Windows.Forms.TextBox();
            this.lblAdresse = new System.Windows.Forms.Label();
            this.txtAdresse = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblTelephone = new System.Windows.Forms.Label();
            this.txtTelephone = new System.Windows.Forms.TextBox();
            this.lblGroupeSanguin = new System.Windows.Forms.Label();
            this.txtGroupeSanguin = new System.Windows.Forms.TextBox();
            this.lblPoids = new System.Windows.Forms.Label();
            this.txtPoids = new System.Windows.Forms.TextBox();
            this.lblTaille = new System.Windows.Forms.Label();
            this.txtTaille = new System.Windows.Forms.TextBox();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnChoisir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgPatient)).BeginInit();
            this.SuspendLayout();
            // 
            // dgPatient
            // 
            this.dgPatient.Location = new System.Drawing.Point(430, 64);
            this.dgPatient.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgPatient.Name = "dgPatient";
            this.dgPatient.Size = new System.Drawing.Size(726, 479);
            this.dgPatient.TabIndex = 17;
            // 
            // lblNomPrenom
            // 
            this.lblNomPrenom.AutoSize = true;
            this.lblNomPrenom.Location = new System.Drawing.Point(3, 11);
            this.lblNomPrenom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNomPrenom.Name = "lblNomPrenom";
            this.lblNomPrenom.Size = new System.Drawing.Size(95, 16);
            this.lblNomPrenom.TabIndex = 1;
            this.lblNomPrenom.Text = "Nom prenom";
            // 
            // txtNomPrenom
            // 
            this.txtNomPrenom.Location = new System.Drawing.Point(3, 31);
            this.txtNomPrenom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNomPrenom.Name = "txtNomPrenom";
            this.txtNomPrenom.Size = new System.Drawing.Size(394, 22);
            this.txtNomPrenom.TabIndex = 1;
            // 
            // lblAdresse
            // 
            this.lblAdresse.AutoSize = true;
            this.lblAdresse.Location = new System.Drawing.Point(3, 63);
            this.lblAdresse.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAdresse.Name = "lblAdresse";
            this.lblAdresse.Size = new System.Drawing.Size(65, 16);
            this.lblAdresse.TabIndex = 3;
            this.lblAdresse.Text = "Adresse";
            // 
            // txtAdresse
            // 
            this.txtAdresse.Location = new System.Drawing.Point(3, 82);
            this.txtAdresse.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAdresse.Name = "txtAdresse";
            this.txtAdresse.Size = new System.Drawing.Size(394, 22);
            this.txtAdresse.TabIndex = 2;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(3, 114);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(46, 16);
            this.lblEmail.TabIndex = 5;
            this.lblEmail.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(3, 134);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(394, 22);
            this.txtEmail.TabIndex = 3;
            // 
            // lblTelephone
            // 
            this.lblTelephone.AutoSize = true;
            this.lblTelephone.Location = new System.Drawing.Point(3, 166);
            this.lblTelephone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTelephone.Name = "lblTelephone";
            this.lblTelephone.Size = new System.Drawing.Size(82, 16);
            this.lblTelephone.TabIndex = 7;
            this.lblTelephone.Text = "Telephone";
            // 
            // txtTelephone
            // 
            this.txtTelephone.Location = new System.Drawing.Point(3, 186);
            this.txtTelephone.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTelephone.Name = "txtTelephone";
            this.txtTelephone.Size = new System.Drawing.Size(394, 22);
            this.txtTelephone.TabIndex = 4;
            // 
            // lblGroupeSanguin
            // 
            this.lblGroupeSanguin.AutoSize = true;
            this.lblGroupeSanguin.Location = new System.Drawing.Point(3, 218);
            this.lblGroupeSanguin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGroupeSanguin.Name = "lblGroupeSanguin";
            this.lblGroupeSanguin.Size = new System.Drawing.Size(118, 16);
            this.lblGroupeSanguin.TabIndex = 9;
            this.lblGroupeSanguin.Text = "Groupe Sanguin";
            // 
            // txtGroupeSanguin
            // 
            this.txtGroupeSanguin.Location = new System.Drawing.Point(3, 238);
            this.txtGroupeSanguin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtGroupeSanguin.Name = "txtGroupeSanguin";
            this.txtGroupeSanguin.Size = new System.Drawing.Size(394, 22);
            this.txtGroupeSanguin.TabIndex = 5;
            // 
            // lblPoids
            // 
            this.lblPoids.AutoSize = true;
            this.lblPoids.Location = new System.Drawing.Point(3, 270);
            this.lblPoids.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPoids.Name = "lblPoids";
            this.lblPoids.Size = new System.Drawing.Size(47, 16);
            this.lblPoids.TabIndex = 11;
            this.lblPoids.Text = "Poids";
            // 
            // txtPoids
            // 
            this.txtPoids.Location = new System.Drawing.Point(3, 289);
            this.txtPoids.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPoids.Name = "txtPoids";
            this.txtPoids.Size = new System.Drawing.Size(394, 22);
            this.txtPoids.TabIndex = 6;
            // 
            // lblTaille
            // 
            this.lblTaille.AutoSize = true;
            this.lblTaille.Location = new System.Drawing.Point(3, 321);
            this.lblTaille.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTaille.Name = "lblTaille";
            this.lblTaille.Size = new System.Drawing.Size(47, 16);
            this.lblTaille.TabIndex = 13;
            this.lblTaille.Text = "Taille";
            // 
            // txtTaille
            // 
            this.txtTaille.Location = new System.Drawing.Point(3, 341);
            this.txtTaille.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTaille.Name = "txtTaille";
            this.txtTaille.Size = new System.Drawing.Size(394, 22);
            this.txtTaille.TabIndex = 7;
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(8, 399);
            this.btnAjouter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(112, 28);
            this.btnAjouter.TabIndex = 8;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(147, 399);
            this.btnModifier.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(112, 28);
            this.btnModifier.TabIndex = 10;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(286, 399);
            this.btnSupprimer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(112, 28);
            this.btnSupprimer.TabIndex = 11;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // btnChoisir
            // 
            this.btnChoisir.Location = new System.Drawing.Point(430, 28);
            this.btnChoisir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnChoisir.Name = "btnChoisir";
            this.btnChoisir.Size = new System.Drawing.Size(112, 28);
            this.btnChoisir.TabIndex = 9;
            this.btnChoisir.Text = "Choisir";
            this.btnChoisir.UseVisualStyleBackColor = true;
            this.btnChoisir.Click += new System.EventHandler(this.btnChoisir_Click);
            // 
            // frmPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 553);
            this.ControlBox = false;
            this.Controls.Add(this.btnChoisir);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.txtTaille);
            this.Controls.Add(this.lblTaille);
            this.Controls.Add(this.txtPoids);
            this.Controls.Add(this.lblPoids);
            this.Controls.Add(this.txtGroupeSanguin);
            this.Controls.Add(this.lblGroupeSanguin);
            this.Controls.Add(this.txtTelephone);
            this.Controls.Add(this.lblTelephone);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtAdresse);
            this.Controls.Add(this.lblAdresse);
            this.Controls.Add(this.txtNomPrenom);
            this.Controls.Add(this.lblNomPrenom);
            this.Controls.Add(this.dgPatient);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmPatient";
            this.Text = "Patient";
            this.Load += new System.EventHandler(this.frmPatient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgPatient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgPatient;
        private System.Windows.Forms.Label lblNomPrenom;
        private System.Windows.Forms.TextBox txtNomPrenom;
        private System.Windows.Forms.Label lblAdresse;
        private System.Windows.Forms.TextBox txtAdresse;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblTelephone;
        private System.Windows.Forms.TextBox txtTelephone;
        private System.Windows.Forms.Label lblGroupeSanguin;
        private System.Windows.Forms.TextBox txtGroupeSanguin;
        private System.Windows.Forms.Label lblPoids;
        private System.Windows.Forms.TextBox txtPoids;
        private System.Windows.Forms.Label lblTaille;
        private System.Windows.Forms.TextBox txtTaille;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnChoisir;
    }
}