namespace Alchifra
{
    partial class FormRapportVisite
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
            this.lblTitre = new System.Windows.Forms.Label();
            this.lblNumRapport = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblPraticien = new System.Windows.Forms.Label();
            this.lblMotif = new System.Windows.Forms.Label();
            this.lblBilan = new System.Windows.Forms.Label();
            this.lblProduit1 = new System.Windows.Forms.Label();
            this.lblEchantillons1 = new System.Windows.Forms.Label();
            this.lblProduit2 = new System.Windows.Forms.Label();
            this.lblEchantillons2 = new System.Windows.Forms.Label();
            this.lblNumRapportVal = new System.Windows.Forms.Label();
            this.dtpDateVisite = new System.Windows.Forms.DateTimePicker();
            this.cbPraticien = new System.Windows.Forms.ComboBox();
            this.cbMotif = new System.Windows.Forms.ComboBox();
            this.txtBilan = new System.Windows.Forms.TextBox();
            this.cbProduit1 = new System.Windows.Forms.ComboBox();
            this.nudEchantillons1 = new System.Windows.Forms.NumericUpDown();
            this.cbProduit2 = new System.Windows.Forms.ComboBox();
            this.nudEchantillons2 = new System.Windows.Forms.NumericUpDown();
            this.btnValider = new System.Windows.Forms.Button();
            this.btnReinitialiser = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.groupBoxProduits = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudEchantillons1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEchantillons2)).BeginInit();
            this.groupBoxProduits.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre.ForeColor = System.Drawing.Color.White;
            this.lblTitre.Location = new System.Drawing.Point(259, 19);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(391, 32);
            this.lblTitre.TabIndex = 0;
            this.lblTitre.Text = "Saisie d\'un rapport de visite";
            // 
            // lblNumRapport
            // 
            this.lblNumRapport.AutoSize = true;
            this.lblNumRapport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblNumRapport.ForeColor = System.Drawing.Color.White;
            this.lblNumRapport.Location = new System.Drawing.Point(34, 75);
            this.lblNumRapport.Name = "lblNumRapport";
            this.lblNumRapport.Size = new System.Drawing.Size(127, 25);
            this.lblNumRapport.TabIndex = 1;
            this.lblNumRapport.Text = "Rapport n° :";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblDate.ForeColor = System.Drawing.Color.White;
            this.lblDate.Location = new System.Drawing.Point(34, 125);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(156, 25);
            this.lblDate.TabIndex = 3;
            this.lblDate.Text = "Date de visite :";
            // 
            // lblPraticien
            // 
            this.lblPraticien.AutoSize = true;
            this.lblPraticien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblPraticien.ForeColor = System.Drawing.Color.White;
            this.lblPraticien.Location = new System.Drawing.Point(34, 175);
            this.lblPraticien.Name = "lblPraticien";
            this.lblPraticien.Size = new System.Drawing.Size(109, 25);
            this.lblPraticien.TabIndex = 5;
            this.lblPraticien.Text = "Praticien :";
            // 
            // lblMotif
            // 
            this.lblMotif.AutoSize = true;
            this.lblMotif.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblMotif.ForeColor = System.Drawing.Color.White;
            this.lblMotif.Location = new System.Drawing.Point(34, 225);
            this.lblMotif.Name = "lblMotif";
            this.lblMotif.Size = new System.Drawing.Size(72, 25);
            this.lblMotif.TabIndex = 7;
            this.lblMotif.Text = "Motif :";
            // 
            // lblBilan
            // 
            this.lblBilan.AutoSize = true;
            this.lblBilan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblBilan.ForeColor = System.Drawing.Color.White;
            this.lblBilan.Location = new System.Drawing.Point(34, 275);
            this.lblBilan.Name = "lblBilan";
            this.lblBilan.Size = new System.Drawing.Size(73, 25);
            this.lblBilan.TabIndex = 9;
            this.lblBilan.Text = "Bilan :";
            // 
            // lblProduit1
            // 
            this.lblProduit1.AutoSize = true;
            this.lblProduit1.Location = new System.Drawing.Point(11, 44);
            this.lblProduit1.Name = "lblProduit1";
            this.lblProduit1.Size = new System.Drawing.Size(111, 25);
            this.lblProduit1.TabIndex = 0;
            this.lblProduit1.Text = "Produit 1 :";
            // 
            // lblEchantillons1
            // 
            this.lblEchantillons1.AutoSize = true;
            this.lblEchantillons1.Location = new System.Drawing.Point(461, 44);
            this.lblEchantillons1.Name = "lblEchantillons1";
            this.lblEchantillons1.Size = new System.Drawing.Size(142, 25);
            this.lblEchantillons1.TabIndex = 2;
            this.lblEchantillons1.Text = "Échantillons :";
            // 
            // lblProduit2
            // 
            this.lblProduit2.AutoSize = true;
            this.lblProduit2.Location = new System.Drawing.Point(11, 106);
            this.lblProduit2.Name = "lblProduit2";
            this.lblProduit2.Size = new System.Drawing.Size(111, 25);
            this.lblProduit2.TabIndex = 4;
            this.lblProduit2.Text = "Produit 2 :";
            // 
            // lblEchantillons2
            // 
            this.lblEchantillons2.AutoSize = true;
            this.lblEchantillons2.Location = new System.Drawing.Point(461, 106);
            this.lblEchantillons2.Name = "lblEchantillons2";
            this.lblEchantillons2.Size = new System.Drawing.Size(142, 25);
            this.lblEchantillons2.TabIndex = 6;
            this.lblEchantillons2.Text = "Échantillons :";
            // 
            // lblNumRapportVal
            // 
            this.lblNumRapportVal.AutoSize = true;
            this.lblNumRapportVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblNumRapportVal.ForeColor = System.Drawing.Color.Yellow;
            this.lblNumRapportVal.Location = new System.Drawing.Point(225, 75);
            this.lblNumRapportVal.Name = "lblNumRapportVal";
            this.lblNumRapportVal.Size = new System.Drawing.Size(70, 25);
            this.lblNumRapportVal.TabIndex = 2;
            this.lblNumRapportVal.Text = "(auto)";
            // 
            // dtpDateVisite
            // 
            this.dtpDateVisite.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateVisite.Location = new System.Drawing.Point(225, 122);
            this.dtpDateVisite.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpDateVisite.Name = "dtpDateVisite";
            this.dtpDateVisite.Size = new System.Drawing.Size(224, 26);
            this.dtpDateVisite.TabIndex = 4;
            // 
            // cbPraticien
            // 
            this.cbPraticien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPraticien.FormattingEnabled = true;
            this.cbPraticien.Location = new System.Drawing.Point(225, 172);
            this.cbPraticien.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbPraticien.Name = "cbPraticien";
            this.cbPraticien.Size = new System.Drawing.Size(337, 28);
            this.cbPraticien.TabIndex = 6;
            // 
            // cbMotif
            // 
            this.cbMotif.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMotif.FormattingEnabled = true;
            this.cbMotif.Items.AddRange(new object[] {
            "Périodicité",
            "Actualisation",
            "Relance",
            "Sollicitation",
            "Autre"});
            this.cbMotif.Location = new System.Drawing.Point(225, 222);
            this.cbMotif.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbMotif.Name = "cbMotif";
            this.cbMotif.Size = new System.Drawing.Size(337, 28);
            this.cbMotif.TabIndex = 8;
            // 
            // txtBilan
            // 
            this.txtBilan.Location = new System.Drawing.Point(225, 272);
            this.txtBilan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBilan.Multiline = true;
            this.txtBilan.Name = "txtBilan";
            this.txtBilan.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBilan.Size = new System.Drawing.Size(562, 124);
            this.txtBilan.TabIndex = 10;
            // 
            // cbProduit1
            // 
            this.cbProduit1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProduit1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cbProduit1.FormattingEnabled = true;
            this.cbProduit1.Location = new System.Drawing.Point(124, 41);
            this.cbProduit1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbProduit1.Name = "cbProduit1";
            this.cbProduit1.Size = new System.Drawing.Size(314, 30);
            this.cbProduit1.TabIndex = 1;
            // 
            // nudEchantillons1
            // 
            this.nudEchantillons1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.nudEchantillons1.Location = new System.Drawing.Point(630, 41);
            this.nudEchantillons1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nudEchantillons1.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.nudEchantillons1.Name = "nudEchantillons1";
            this.nudEchantillons1.Size = new System.Drawing.Size(90, 28);
            this.nudEchantillons1.TabIndex = 3;
            // 
            // cbProduit2
            // 
            this.cbProduit2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProduit2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cbProduit2.FormattingEnabled = true;
            this.cbProduit2.Location = new System.Drawing.Point(124, 104);
            this.cbProduit2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbProduit2.Name = "cbProduit2";
            this.cbProduit2.Size = new System.Drawing.Size(314, 30);
            this.cbProduit2.TabIndex = 5;
            // 
            // nudEchantillons2
            // 
            this.nudEchantillons2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.nudEchantillons2.Location = new System.Drawing.Point(630, 104);
            this.nudEchantillons2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nudEchantillons2.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.nudEchantillons2.Name = "nudEchantillons2";
            this.nudEchantillons2.Size = new System.Drawing.Size(90, 28);
            this.nudEchantillons2.TabIndex = 7;
            // 
            // btnValider
            // 
            this.btnValider.BackColor = System.Drawing.Color.DarkGreen;
            this.btnValider.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnValider.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnValider.ForeColor = System.Drawing.Color.White;
            this.btnValider.Location = new System.Drawing.Point(169, 625);
            this.btnValider.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(146, 44);
            this.btnValider.TabIndex = 12;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = false;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // btnReinitialiser
            // 
            this.btnReinitialiser.BackColor = System.Drawing.Color.DarkOrange;
            this.btnReinitialiser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReinitialiser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnReinitialiser.ForeColor = System.Drawing.Color.White;
            this.btnReinitialiser.Location = new System.Drawing.Point(349, 625);
            this.btnReinitialiser.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnReinitialiser.Name = "btnReinitialiser";
            this.btnReinitialiser.Size = new System.Drawing.Size(146, 44);
            this.btnReinitialiser.TabIndex = 13;
            this.btnReinitialiser.Text = "Réinitialiser";
            this.btnReinitialiser.UseVisualStyleBackColor = false;
            this.btnReinitialiser.Click += new System.EventHandler(this.btnReinitialiser_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.BackColor = System.Drawing.Color.Firebrick;
            this.btnAnnuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnnuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnAnnuler.ForeColor = System.Drawing.Color.White;
            this.btnAnnuler.Location = new System.Drawing.Point(529, 625);
            this.btnAnnuler.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(146, 44);
            this.btnAnnuler.TabIndex = 14;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = false;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // groupBoxProduits
            // 
            this.groupBoxProduits.Controls.Add(this.lblProduit1);
            this.groupBoxProduits.Controls.Add(this.cbProduit1);
            this.groupBoxProduits.Controls.Add(this.lblEchantillons1);
            this.groupBoxProduits.Controls.Add(this.nudEchantillons1);
            this.groupBoxProduits.Controls.Add(this.lblProduit2);
            this.groupBoxProduits.Controls.Add(this.cbProduit2);
            this.groupBoxProduits.Controls.Add(this.lblEchantillons2);
            this.groupBoxProduits.Controls.Add(this.nudEchantillons2);
            this.groupBoxProduits.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.groupBoxProduits.ForeColor = System.Drawing.Color.White;
            this.groupBoxProduits.Location = new System.Drawing.Point(34, 419);
            this.groupBoxProduits.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxProduits.Name = "groupBoxProduits";
            this.groupBoxProduits.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxProduits.Size = new System.Drawing.Size(754, 175);
            this.groupBoxProduits.TabIndex = 11;
            this.groupBoxProduits.TabStop = false;
            this.groupBoxProduits.Text = "Produits offerts (maximum 2)";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Alchifra.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(679, 47);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(144, 125);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // FormRapportVisite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(844, 700);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblTitre);
            this.Controls.Add(this.lblNumRapport);
            this.Controls.Add(this.lblNumRapportVal);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.dtpDateVisite);
            this.Controls.Add(this.lblPraticien);
            this.Controls.Add(this.cbPraticien);
            this.Controls.Add(this.lblMotif);
            this.Controls.Add(this.cbMotif);
            this.Controls.Add(this.lblBilan);
            this.Controls.Add(this.txtBilan);
            this.Controls.Add(this.groupBoxProduits);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.btnReinitialiser);
            this.Controls.Add(this.btnAnnuler);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "FormRapportVisite";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Saisie d\'un rapport de visite";
            this.Load += new System.EventHandler(this.FormRapportVisite_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudEchantillons1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEchantillons2)).EndInit();
            this.groupBoxProduits.ResumeLayout(false);
            this.groupBoxProduits.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.Label lblNumRapport;
        private System.Windows.Forms.Label lblNumRapportVal;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker dtpDateVisite;
        private System.Windows.Forms.Label lblPraticien;
        private System.Windows.Forms.ComboBox cbPraticien;
        private System.Windows.Forms.Label lblMotif;
        private System.Windows.Forms.ComboBox cbMotif;
        private System.Windows.Forms.Label lblBilan;
        private System.Windows.Forms.TextBox txtBilan;
        private System.Windows.Forms.GroupBox groupBoxProduits;
        private System.Windows.Forms.Label lblProduit1;
        private System.Windows.Forms.ComboBox cbProduit1;
        private System.Windows.Forms.Label lblEchantillons1;
        private System.Windows.Forms.NumericUpDown nudEchantillons1;
        private System.Windows.Forms.Label lblProduit2;
        private System.Windows.Forms.ComboBox cbProduit2;
        private System.Windows.Forms.Label lblEchantillons2;
        private System.Windows.Forms.NumericUpDown nudEchantillons2;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Button btnReinitialiser;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
