namespace Alchifra
{
    partial class FormProduit
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
            this.lblNomProduit = new System.Windows.Forms.Label();
            this.cbProduitS = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNumeroTitre = new System.Windows.Forms.Label();
            this.lblFamilleTitre = new System.Windows.Forms.Label();
            this.lblPrixTitre = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblEffetsTitre = new System.Windows.Forms.Label();
            this.lblContreIndicationsTitre = new System.Windows.Forms.Label();
            this.lblInteractionsTitre = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtFamille = new System.Windows.Forms.TextBox();
            this.txtPrix = new System.Windows.Forms.TextBox();
            this.rtbEffets = new System.Windows.Forms.RichTextBox();
            this.rtbContreInterdications = new System.Windows.Forms.RichTextBox();
            this.rtbInteractions = new System.Windows.Forms.RichTextBox();
            this.dgvComposants = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComposants)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNomProduit
            // 
            this.lblNomProduit.AutoSize = true;
            this.lblNomProduit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.1F);
            this.lblNomProduit.Location = new System.Drawing.Point(31, 30);
            this.lblNomProduit.Name = "lblNomProduit";
            this.lblNomProduit.Size = new System.Drawing.Size(62, 20);
            this.lblNomProduit.TabIndex = 0;
            this.lblNomProduit.Text = "Produit";
            // 
            // cbProduitS
            // 
            this.cbProduitS.FormattingEnabled = true;
            this.cbProduitS.Location = new System.Drawing.Point(109, 30);
            this.cbProduitS.Name = "cbProduitS";
            this.cbProduitS.Size = new System.Drawing.Size(235, 24);
            this.cbProduitS.TabIndex = 1;
            this.cbProduitS.SelectedIndexChanged += new System.EventHandler(this.cbProduitS_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(231, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Informations générales";
            // 
            // lblNumeroTitre
            // 
            this.lblNumeroTitre.AutoSize = true;
            this.lblNumeroTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroTitre.Location = new System.Drawing.Point(49, 123);
            this.lblNumeroTitre.Name = "lblNumeroTitre";
            this.lblNumeroTitre.Size = new System.Drawing.Size(166, 20);
            this.lblNumeroTitre.TabIndex = 3;
            this.lblNumeroTitre.Text = "Numéro (dépôt légal)";
            // 
            // lblFamilleTitre
            // 
            this.lblFamilleTitre.AutoSize = true;
            this.lblFamilleTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFamilleTitre.Location = new System.Drawing.Point(50, 167);
            this.lblFamilleTitre.Name = "lblFamilleTitre";
            this.lblFamilleTitre.Size = new System.Drawing.Size(63, 20);
            this.lblFamilleTitre.TabIndex = 4;
            this.lblFamilleTitre.Text = "Famille";
            // 
            // lblPrixTitre
            // 
            this.lblPrixTitre.AutoSize = true;
            this.lblPrixTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrixTitre.Location = new System.Drawing.Point(51, 217);
            this.lblPrixTitre.Name = "lblPrixTitre";
            this.lblPrixTitre.Size = new System.Drawing.Size(38, 20);
            this.lblPrixTitre.TabIndex = 5;
            this.lblPrixTitre.Text = "Prix";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(595, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 25);
            this.label6.TabIndex = 6;
            this.label6.Text = "Composants";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(45, 261);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(233, 25);
            this.label7.TabIndex = 7;
            this.label7.Text = "Informations médicales";
            // 
            // lblEffetsTitre
            // 
            this.lblEffetsTitre.AutoSize = true;
            this.lblEffetsTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEffetsTitre.Location = new System.Drawing.Point(46, 308);
            this.lblEffetsTitre.Name = "lblEffetsTitre";
            this.lblEffetsTitre.Size = new System.Drawing.Size(168, 20);
            this.lblEffetsTitre.TabIndex = 8;
            this.lblEffetsTitre.Text = "Effets thérapeutiques";
            // 
            // lblContreIndicationsTitre
            // 
            this.lblContreIndicationsTitre.AutoSize = true;
            this.lblContreIndicationsTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContreIndicationsTitre.Location = new System.Drawing.Point(52, 376);
            this.lblContreIndicationsTitre.Name = "lblContreIndicationsTitre";
            this.lblContreIndicationsTitre.Size = new System.Drawing.Size(142, 20);
            this.lblContreIndicationsTitre.TabIndex = 9;
            this.lblContreIndicationsTitre.Text = "contre-indications";
            // 
            // lblInteractionsTitre
            // 
            this.lblInteractionsTitre.AutoSize = true;
            this.lblInteractionsTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInteractionsTitre.Location = new System.Drawing.Point(52, 436);
            this.lblInteractionsTitre.Name = "lblInteractionsTitre";
            this.lblInteractionsTitre.Size = new System.Drawing.Size(96, 20);
            this.lblInteractionsTitre.TabIndex = 10;
            this.lblInteractionsTitre.Text = "Interactions";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(271, 123);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(100, 22);
            this.txtNumero.TabIndex = 11;
            // 
            // txtFamille
            // 
            this.txtFamille.Location = new System.Drawing.Point(271, 167);
            this.txtFamille.Name = "txtFamille";
            this.txtFamille.Size = new System.Drawing.Size(100, 22);
            this.txtFamille.TabIndex = 12;
            // 
            // txtPrix
            // 
            this.txtPrix.Location = new System.Drawing.Point(271, 215);
            this.txtPrix.Name = "txtPrix";
            this.txtPrix.Size = new System.Drawing.Size(100, 22);
            this.txtPrix.TabIndex = 13;
            // 
            // rtbEffets
            // 
            this.rtbEffets.Location = new System.Drawing.Point(244, 308);
            this.rtbEffets.Name = "rtbEffets";
            this.rtbEffets.Size = new System.Drawing.Size(575, 31);
            this.rtbEffets.TabIndex = 23;
            this.rtbEffets.Text = "";
            // 
            // rtbContreInterdications
            // 
            this.rtbContreInterdications.Location = new System.Drawing.Point(244, 376);
            this.rtbContreInterdications.Name = "rtbContreInterdications";
            this.rtbContreInterdications.Size = new System.Drawing.Size(575, 35);
            this.rtbContreInterdications.TabIndex = 24;
            this.rtbContreInterdications.Text = "";
            // 
            // rtbInteractions
            // 
            this.rtbInteractions.Location = new System.Drawing.Point(244, 436);
            this.rtbInteractions.Name = "rtbInteractions";
            this.rtbInteractions.Size = new System.Drawing.Size(575, 36);
            this.rtbInteractions.TabIndex = 25;
            this.rtbInteractions.Text = "";
            // 
            // dgvComposants
            // 
            this.dgvComposants.AllowUserToAddRows = false;
            this.dgvComposants.AllowUserToDeleteRows = false;
            this.dgvComposants.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvComposants.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvComposants.Location = new System.Drawing.Point(514, 148);
            this.dgvComposants.Name = "dgvComposants";
            this.dgvComposants.ReadOnly = true;
            this.dgvComposants.RowHeadersWidth = 51;
            this.dgvComposants.RowTemplate.Height = 24;
            this.dgvComposants.Size = new System.Drawing.Size(335, 138);
            this.dgvComposants.TabIndex = 26;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.ErrorImage = global::Alchifra.Properties.Resources.logo;
            this.pictureBox1.Image = global::Alchifra.Properties.Resources.logo;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(775, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 76);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // FormProduit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(887, 533);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgvComposants);
            this.Controls.Add(this.rtbInteractions);
            this.Controls.Add(this.rtbContreInterdications);
            this.Controls.Add(this.rtbEffets);
            this.Controls.Add(this.txtPrix);
            this.Controls.Add(this.txtFamille);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.lblInteractionsTitre);
            this.Controls.Add(this.lblContreIndicationsTitre);
            this.Controls.Add(this.lblEffetsTitre);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblPrixTitre);
            this.Controls.Add(this.lblFamilleTitre);
            this.Controls.Add(this.lblNumeroTitre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbProduitS);
            this.Controls.Add(this.lblNomProduit);
            this.Name = "FormProduit";
            this.Text = "Fiche d\'un produit";
            this.Load += new System.EventHandler(this.FormProduit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvComposants)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNomProduit;
        private System.Windows.Forms.ComboBox cbProduitS;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNumeroTitre;
        private System.Windows.Forms.Label lblFamilleTitre;
        private System.Windows.Forms.Label lblPrixTitre;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblEffetsTitre;
        private System.Windows.Forms.Label lblContreIndicationsTitre;
        private System.Windows.Forms.Label lblInteractionsTitre;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.TextBox txtFamille;
        private System.Windows.Forms.TextBox txtPrix;
        private System.Windows.Forms.RichTextBox rtbEffets;
        private System.Windows.Forms.RichTextBox rtbContreInterdications;
        private System.Windows.Forms.RichTextBox rtbInteractions;
        private System.Windows.Forms.DataGridView dgvComposants;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}