namespace Alchifra
{
    partial class FormConsultationRapport
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblTitre = new System.Windows.Forms.Label();
            this.lblSelection = new System.Windows.Forms.Label();
            this.cbRapport = new System.Windows.Forms.ComboBox();
            this.gbDetails = new System.Windows.Forms.GroupBox();
            this.lblAuteurVal = new System.Windows.Forms.Label();
            this.lblAuteur = new System.Windows.Forms.Label();
            this.lblMotifVal = new System.Windows.Forms.Label();
            this.lblMotif = new System.Windows.Forms.Label();
            this.lblPraticienVal = new System.Windows.Forms.Label();
            this.lblPraticien = new System.Windows.Forms.Label();
            this.lblDateVal = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.txtBilan = new System.Windows.Forms.TextBox();
            this.lblBilan = new System.Windows.Forms.Label();
            this.dgvProduits = new System.Windows.Forms.DataGridView();
            this.lblProduits = new System.Windows.Forms.Label();
            this.btnFermer = new System.Windows.Forms.Button();
            this.btnValiderSelection = new System.Windows.Forms.Button();    
            this.gbDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduits)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitre.ForeColor = System.Drawing.Color.White;
            this.lblTitre.Location = new System.Drawing.Point(232, 19);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(460, 32);
            this.lblTitre.TabIndex = 0;
            this.lblTitre.Text = "Consultation des rapports de visite";
            // 
            // lblSelection
            // 
            this.lblSelection.AutoSize = true;
            this.lblSelection.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblSelection.ForeColor = System.Drawing.Color.White;
            this.lblSelection.Location = new System.Drawing.Point(34, 75);
            this.lblSelection.Name = "lblSelection";
            this.lblSelection.Size = new System.Drawing.Size(225, 25);
            this.lblSelection.TabIndex = 1;
            this.lblSelection.Text = "Choisir un rapport :";
            // 
            // cbRapport
            // 
            this.cbRapport.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRapport.FormattingEnabled = true;
            this.cbRapport.Location = new System.Drawing.Point(265, 75);
            this.cbRapport.Name = "cbRapport";
            this.cbRapport.Size = new System.Drawing.Size(522, 28);
            this.cbRapport.TabIndex = 2;
            this.cbRapport.SelectedIndexChanged += new System.EventHandler(this.cbRapport_SelectedIndexChanged);
            // 
            // btnValiderSelection
            // 
            this.btnValiderSelection.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnValiderSelection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnValiderSelection.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnValiderSelection.ForeColor = System.Drawing.Color.White;
            this.btnValiderSelection.Location = new System.Drawing.Point(685, 72);
            this.btnValiderSelection.Name = "btnValiderSelection";
            this.btnValiderSelection.Size = new System.Drawing.Size(102, 33);
            this.btnValiderSelection.TabIndex = 9;
            this.btnValiderSelection.Text = "Valider";
            this.btnValiderSelection.UseVisualStyleBackColor = false;
            this.btnValiderSelection.Click += new System.EventHandler(this.btnValiderSelection_Click);
            //            
            // gbDetails
            // 
            this.gbDetails.Controls.Add(this.lblAuteurVal);
            this.gbDetails.Controls.Add(this.lblAuteur);
            this.gbDetails.Controls.Add(this.lblMotifVal);
            this.gbDetails.Controls.Add(this.lblMotif);
            this.gbDetails.Controls.Add(this.lblPraticienVal);
            this.gbDetails.Controls.Add(this.lblPraticien);
            this.gbDetails.Controls.Add(this.lblDateVal);
            this.gbDetails.Controls.Add(this.lblDate);
            this.gbDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.gbDetails.ForeColor = System.Drawing.Color.White;
            this.gbDetails.Location = new System.Drawing.Point(34, 125);
            this.gbDetails.Name = "gbDetails";
            this.gbDetails.Size = new System.Drawing.Size(753, 150);
            this.gbDetails.TabIndex = 3;
            this.gbDetails.TabStop = false;
            this.gbDetails.Text = "Informations générales";
            // 
            // lblAuteurVal
            // 
            this.lblAuteurVal.AutoSize = true;
            this.lblAuteurVal.ForeColor = System.Drawing.Color.Yellow;
            this.lblAuteurVal.Location = new System.Drawing.Point(130, 110);
            this.lblAuteurVal.Name = "lblAuteurVal";
            this.lblAuteurVal.Size = new System.Drawing.Size(0, 25);
            this.lblAuteurVal.TabIndex = 7;
            // 
            // lblAuteur
            // 
            this.lblAuteur.AutoSize = true;
            this.lblAuteur.Location = new System.Drawing.Point(11, 110);
            this.lblAuteur.Name = "lblAuteur";
            this.lblAuteur.Size = new System.Drawing.Size(100, 25);
            this.lblAuteur.TabIndex = 6;
            this.lblAuteur.Text = "Auteur :";
            // 
            // lblMotifVal
            // 
            this.lblMotifVal.AutoSize = true;
            this.lblMotifVal.ForeColor = System.Drawing.Color.Yellow;
            this.lblMotifVal.Location = new System.Drawing.Point(450, 70);
            this.lblMotifVal.Name = "lblMotifVal";
            this.lblMotifVal.Size = new System.Drawing.Size(0, 25);
            this.lblMotifVal.TabIndex = 5;
            // 
            // lblMotif
            // 
            this.lblMotif.AutoSize = true;
            this.lblMotif.Location = new System.Drawing.Point(350, 70);
            this.lblMotif.Name = "lblMotif";
            this.lblMotif.Size = new System.Drawing.Size(84, 25);
            this.lblMotif.TabIndex = 4;
            this.lblMotif.Text = "Motif :";
            // 
            // lblPraticienVal
            // 
            this.lblPraticienVal.AutoSize = true;
            this.lblPraticienVal.ForeColor = System.Drawing.Color.Yellow;
            this.lblPraticienVal.Location = new System.Drawing.Point(130, 70);
            this.lblPraticienVal.Name = "lblPraticienVal";
            this.lblPraticienVal.Size = new System.Drawing.Size(0, 25);
            this.lblPraticienVal.TabIndex = 3;
            // 
            // lblPraticien
            // 
            this.lblPraticien.AutoSize = true;
            this.lblPraticien.Location = new System.Drawing.Point(11, 70);
            this.lblPraticien.Name = "lblPraticien";
            this.lblPraticien.Size = new System.Drawing.Size(121, 25);
            this.lblPraticien.TabIndex = 2;
            this.lblPraticien.Text = "Praticien :";
            // 
            // lblDateVal
            // 
            this.lblDateVal.AutoSize = true;
            this.lblDateVal.ForeColor = System.Drawing.Color.Yellow;
            this.lblDateVal.Location = new System.Drawing.Point(130, 30);
            this.lblDateVal.Name = "lblDateVal";
            this.lblDateVal.Size = new System.Drawing.Size(0, 25);
            this.lblDateVal.TabIndex = 1;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(11, 30);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(71, 25);
            this.lblDate.TabIndex = 0;
            this.lblDate.Text = "Date :";
            // 
            // txtBilan
            // 
            this.txtBilan.Location = new System.Drawing.Point(34, 310);
            this.txtBilan.Multiline = true;
            this.txtBilan.Name = "txtBilan";
            this.txtBilan.ReadOnly = true;
            this.txtBilan.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBilan.Size = new System.Drawing.Size(753, 100);
            this.txtBilan.TabIndex = 5;
            // 
            // lblBilan
            // 
            this.lblBilan.AutoSize = true;
            this.lblBilan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblBilan.ForeColor = System.Drawing.Color.White;
            this.lblBilan.Location = new System.Drawing.Point(34, 285);
            this.lblBilan.Name = "lblBilan";
            this.lblBilan.Size = new System.Drawing.Size(79, 25);
            this.lblBilan.TabIndex = 4;
            this.lblBilan.Text = "Bilan :";
            // 
            // dgvProduits
            // 
            this.dgvProduits.AllowUserToAddRows = false;
            this.dgvProduits.AllowUserToDeleteRows = false;
            this.dgvProduits.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProduits.BackgroundColor = System.Drawing.Color.White;
            this.dgvProduits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduits.Location = new System.Drawing.Point(34, 445);
            this.dgvProduits.Name = "dgvProduits";
            this.dgvProduits.ReadOnly = true;
            this.dgvProduits.RowHeadersVisible = false;
            this.dgvProduits.RowHeadersWidth = 62;
            this.dgvProduits.Size = new System.Drawing.Size(753, 150);
            this.dgvProduits.TabIndex = 6;
            // 
            // lblProduits
            // 
            this.lblProduits.AutoSize = true;
            this.lblProduits.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblProduits.ForeColor = System.Drawing.Color.White;
            this.lblProduits.Location = new System.Drawing.Point(34, 420);
            this.lblProduits.Name = "lblProduits";
            this.lblProduits.Size = new System.Drawing.Size(188, 25);
            this.lblProduits.TabIndex = 7;
            this.lblProduits.Text = "Produits offerts :";
            // 
            // btnFermer
            // 
            this.btnFermer.BackColor = System.Drawing.Color.Firebrick;
            this.btnFermer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFermer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnFermer.ForeColor = System.Drawing.Color.White;
            this.btnFermer.Location = new System.Drawing.Point(340, 615);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(146, 44);
            this.btnFermer.TabIndex = 8;
            this.btnFermer.Text = "Fermer";
            this.btnFermer.UseVisualStyleBackColor = false;
            this.btnFermer.Click += new System.EventHandler(this.btnFermer_Click);
            // 
            // FormConsultationRapport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(844, 680);
            this.Controls.Add(this.btnFermer);
            this.Controls.Add(this.btnValiderSelection);  
            this.Controls.Add(this.lblProduits);
            this.Controls.Add(this.dgvProduits);
            this.Controls.Add(this.txtBilan);
            this.Controls.Add(this.lblBilan);
            this.Controls.Add(this.gbDetails);
            this.Controls.Add(this.cbRapport);
            this.Controls.Add(this.lblSelection);
            this.Controls.Add(this.lblTitre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormConsultationRapport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Consultation des rapports de visite";
            this.Load += new System.EventHandler(this.FormConsultationRapport_Load);
            this.gbDetails.ResumeLayout(false);
            this.gbDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduits)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.Label lblSelection;
        private System.Windows.Forms.ComboBox cbRapport;
        private System.Windows.Forms.GroupBox gbDetails;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblDateVal;
        private System.Windows.Forms.Label lblPraticien;
        private System.Windows.Forms.Label lblPraticienVal;
        private System.Windows.Forms.Label lblMotif;
        private System.Windows.Forms.Label lblMotifVal;
        private System.Windows.Forms.Label lblAuteur;
        private System.Windows.Forms.Label lblAuteurVal;
        private System.Windows.Forms.Label lblBilan;
        private System.Windows.Forms.TextBox txtBilan;
        private System.Windows.Forms.DataGridView dgvProduits;
        private System.Windows.Forms.Label lblProduits;
        private System.Windows.Forms.Button btnFermer;
        private System.Windows.Forms.Button btnValiderSelection;
    }
}
