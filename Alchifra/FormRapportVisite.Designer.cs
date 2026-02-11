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
            ((System.ComponentModel.ISupportInitialize)(this.nudEchantillons1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEchantillons2)).BeginInit();
            this.groupBoxProduits.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre.ForeColor = System.Drawing.Color.White;
            this.lblTitre.Location = new System.Drawing.Point(230, 15);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(320, 29);
            this.lblTitre.TabIndex = 0;
            this.lblTitre.Text = "Saisie d'un rapport de visite";
            // 
            // lblNumRapport
            // 
            this.lblNumRapport.AutoSize = true;
            this.lblNumRapport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblNumRapport.ForeColor = System.Drawing.Color.White;
            this.lblNumRapport.Location = new System.Drawing.Point(30, 60);
            this.lblNumRapport.Name = "lblNumRapport";
            this.lblNumRapport.Size = new System.Drawing.Size(162, 20);
            this.lblNumRapport.TabIndex = 1;
            this.lblNumRapport.Text = "Rapport n° :";
            // 
            // lblNumRapportVal
            // 
            this.lblNumRapportVal.AutoSize = true;
            this.lblNumRapportVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblNumRapportVal.ForeColor = System.Drawing.Color.Yellow;
            this.lblNumRapportVal.Location = new System.Drawing.Point(200, 60);
            this.lblNumRapportVal.Name = "lblNumRapportVal";
            this.lblNumRapportVal.Size = new System.Drawing.Size(50, 20);
            this.lblNumRapportVal.TabIndex = 2;
            this.lblNumRapportVal.Text = "(auto)";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblDate.ForeColor = System.Drawing.Color.White;
            this.lblDate.Location = new System.Drawing.Point(30, 100);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(130, 20);
            this.lblDate.TabIndex = 3;
            this.lblDate.Text = "Date de visite :";
            // 
            // dtpDateVisite
            // 
            this.dtpDateVisite.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateVisite.Location = new System.Drawing.Point(200, 98);
            this.dtpDateVisite.Name = "dtpDateVisite";
            this.dtpDateVisite.Size = new System.Drawing.Size(200, 22);
            this.dtpDateVisite.TabIndex = 4;
            // 
            // lblPraticien
            // 
            this.lblPraticien.AutoSize = true;
            this.lblPraticien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblPraticien.ForeColor = System.Drawing.Color.White;
            this.lblPraticien.Location = new System.Drawing.Point(30, 140);
            this.lblPraticien.Name = "lblPraticien";
            this.lblPraticien.Size = new System.Drawing.Size(96, 20);
            this.lblPraticien.TabIndex = 5;
            this.lblPraticien.Text = "Praticien :";
            // 
            // cbPraticien
            // 
            this.cbPraticien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPraticien.FormattingEnabled = true;
            this.cbPraticien.Location = new System.Drawing.Point(200, 138);
            this.cbPraticien.Name = "cbPraticien";
            this.cbPraticien.Size = new System.Drawing.Size(300, 24);
            this.cbPraticien.TabIndex = 6;
            // 
            // lblMotif
            // 
            this.lblMotif.AutoSize = true;
            this.lblMotif.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblMotif.ForeColor = System.Drawing.Color.White;
            this.lblMotif.Location = new System.Drawing.Point(30, 180);
            this.lblMotif.Name = "lblMotif";
            this.lblMotif.Size = new System.Drawing.Size(64, 20);
            this.lblMotif.TabIndex = 7;
            this.lblMotif.Text = "Motif :";
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
            this.cbMotif.Location = new System.Drawing.Point(200, 178);
            this.cbMotif.Name = "cbMotif";
            this.cbMotif.Size = new System.Drawing.Size(300, 24);
            this.cbMotif.TabIndex = 8;
            // 
            // lblBilan
            // 
            this.lblBilan.AutoSize = true;
            this.lblBilan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblBilan.ForeColor = System.Drawing.Color.White;
            this.lblBilan.Location = new System.Drawing.Point(30, 220);
            this.lblBilan.Name = "lblBilan";
            this.lblBilan.Size = new System.Drawing.Size(60, 20);
            this.lblBilan.TabIndex = 9;
            this.lblBilan.Text = "Bilan :";
            // 
            // txtBilan
            // 
            this.txtBilan.Location = new System.Drawing.Point(200, 218);
            this.txtBilan.Multiline = true;
            this.txtBilan.Name = "txtBilan";
            this.txtBilan.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBilan.Size = new System.Drawing.Size(500, 100);
            this.txtBilan.TabIndex = 10;
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
            this.groupBoxProduits.Location = new System.Drawing.Point(30, 335);
            this.groupBoxProduits.Name = "groupBoxProduits";
            this.groupBoxProduits.Size = new System.Drawing.Size(670, 140);
            this.groupBoxProduits.TabIndex = 11;
            this.groupBoxProduits.TabStop = false;
            this.groupBoxProduits.Text = "Produits offerts (maximum 2)";
            // 
            // lblProduit1
            // 
            this.lblProduit1.AutoSize = true;
            this.lblProduit1.Location = new System.Drawing.Point(10, 35);
            this.lblProduit1.Name = "lblProduit1";
            this.lblProduit1.Size = new System.Drawing.Size(90, 20);
            this.lblProduit1.TabIndex = 0;
            this.lblProduit1.Text = "Produit 1 :";
            // 
            // cbProduit1
            // 
            this.cbProduit1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProduit1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cbProduit1.FormattingEnabled = true;
            this.cbProduit1.Location = new System.Drawing.Point(110, 33);
            this.cbProduit1.Name = "cbProduit1";
            this.cbProduit1.Size = new System.Drawing.Size(280, 23);
            this.cbProduit1.TabIndex = 1;
            // 
            // lblEchantillons1
            // 
            this.lblEchantillons1.AutoSize = true;
            this.lblEchantillons1.Location = new System.Drawing.Point(410, 35);
            this.lblEchantillons1.Name = "lblEchantillons1";
            this.lblEchantillons1.Size = new System.Drawing.Size(138, 20);
            this.lblEchantillons1.TabIndex = 2;
            this.lblEchantillons1.Text = "Échantillons :";
            // 
            // nudEchantillons1
            // 
            this.nudEchantillons1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.nudEchantillons1.Location = new System.Drawing.Point(560, 33);
            this.nudEchantillons1.Maximum = new decimal(new int[] { 999, 0, 0, 0 });
            this.nudEchantillons1.Name = "nudEchantillons1";
            this.nudEchantillons1.Size = new System.Drawing.Size(80, 21);
            this.nudEchantillons1.TabIndex = 3;
            // 
            // lblProduit2
            // 
            this.lblProduit2.AutoSize = true;
            this.lblProduit2.Location = new System.Drawing.Point(10, 85);
            this.lblProduit2.Name = "lblProduit2";
            this.lblProduit2.Size = new System.Drawing.Size(90, 20);
            this.lblProduit2.TabIndex = 4;
            this.lblProduit2.Text = "Produit 2 :";
            // 
            // cbProduit2
            // 
            this.cbProduit2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProduit2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cbProduit2.FormattingEnabled = true;
            this.cbProduit2.Location = new System.Drawing.Point(110, 83);
            this.cbProduit2.Name = "cbProduit2";
            this.cbProduit2.Size = new System.Drawing.Size(280, 23);
            this.cbProduit2.TabIndex = 5;
            // 
            // lblEchantillons2
            // 
            this.lblEchantillons2.AutoSize = true;
            this.lblEchantillons2.Location = new System.Drawing.Point(410, 85);
            this.lblEchantillons2.Name = "lblEchantillons2";
            this.lblEchantillons2.Size = new System.Drawing.Size(138, 20);
            this.lblEchantillons2.TabIndex = 6;
            this.lblEchantillons2.Text = "Échantillons :";
            // 
            // nudEchantillons2
            // 
            this.nudEchantillons2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.nudEchantillons2.Location = new System.Drawing.Point(560, 83);
            this.nudEchantillons2.Maximum = new decimal(new int[] { 999, 0, 0, 0 });
            this.nudEchantillons2.Name = "nudEchantillons2";
            this.nudEchantillons2.Size = new System.Drawing.Size(80, 21);
            this.nudEchantillons2.TabIndex = 7;
            // 
            // btnValider
            // 
            this.btnValider.BackColor = System.Drawing.Color.DarkGreen;
            this.btnValider.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnValider.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnValider.ForeColor = System.Drawing.Color.White;
            this.btnValider.Location = new System.Drawing.Point(150, 500);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(130, 35);
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
            this.btnReinitialiser.Location = new System.Drawing.Point(310, 500);
            this.btnReinitialiser.Name = "btnReinitialiser";
            this.btnReinitialiser.Size = new System.Drawing.Size(130, 35);
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
            this.btnAnnuler.Location = new System.Drawing.Point(470, 500);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(130, 35);
            this.btnAnnuler.TabIndex = 14;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = false;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // FormRapportVisite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(750, 560);
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
            this.MaximizeBox = false;
            this.Name = "FormRapportVisite";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Saisie d'un rapport de visite";
            this.Load += new System.EventHandler(this.FormRapportVisite_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudEchantillons1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEchantillons2)).EndInit();
            this.groupBoxProduits.ResumeLayout(false);
            this.groupBoxProduits.PerformLayout();
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
    }
}
