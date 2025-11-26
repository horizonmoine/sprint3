namespace Alchifra
{
    partial class FormPraticien
    {

        private System.ComponentModel.IContainer components = null;

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
            this.cbPraticiens = new System.Windows.Forms.ComboBox();
            this.lblNomPraticien = new System.Windows.Forms.Label();
            this.lblAdresseTitre = new System.Windows.Forms.Label();
            this.lblAdresseVal = new System.Windows.Forms.Label();
            this.lblCpTitre = new System.Windows.Forms.Label();
            this.lblCpVal = new System.Windows.Forms.Label();
            this.lblVilleTitre = new System.Windows.Forms.Label();
            this.lblVilleVal = new System.Windows.Forms.Label();
            this.lblCoefNotorieteTitre = new System.Windows.Forms.Label();
            this.lblCoefNotorieteVal = new System.Windows.Forms.Label();
            this.lblSpecialiteTitre = new System.Windows.Forms.Label();
            this.lblSpecialiteVal = new System.Windows.Forms.Label();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.pbUser = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblDiplomeTitre = new System.Windows.Forms.Label();
            this.lblDiplomeVal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUser)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbPraticiens
            // 
            this.cbPraticiens.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbPraticiens.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPraticiens.FormattingEnabled = true;
            this.cbPraticiens.Location = new System.Drawing.Point(300, 40);
            this.cbPraticiens.Name = "cbPraticiens";
            this.cbPraticiens.Size = new System.Drawing.Size(200, 21);
            this.cbPraticiens.TabIndex = 0;
            this.cbPraticiens.SelectedIndexChanged += new System.EventHandler(this.cbPraticiens_SelectedIndexChanged);
            // 
            // lblNomPraticien
            // 
            this.lblNomPraticien.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblNomPraticien.AutoSize = true;
            this.lblNomPraticien.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomPraticien.Location = new System.Drawing.Point(280, 80);
            this.lblNomPraticien.Name = "lblNomPraticien";
            this.lblNomPraticien.Size = new System.Drawing.Size(242, 37);
            this.lblNomPraticien.TabIndex = 1;
            this.lblNomPraticien.Text = "NOM PRATICIEN";
            this.lblNomPraticien.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblAdresseTitre
            // 
            this.lblAdresseTitre.AutoSize = true;
            this.lblAdresseTitre.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdresseTitre.Location = new System.Drawing.Point(250, 150);
            this.lblAdresseTitre.Name = "lblAdresseTitre";
            this.lblAdresseTitre.Size = new System.Drawing.Size(72, 21);
            this.lblAdresseTitre.TabIndex = 2;
            this.lblAdresseTitre.Text = "Adresse :";
            // 
            // lblAdresseVal
            // 
            this.lblAdresseVal.AutoSize = true;
            this.lblAdresseVal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdresseVal.Location = new System.Drawing.Point(400, 150);
            this.lblAdresseVal.Name = "lblAdresseVal";
            this.lblAdresseVal.Size = new System.Drawing.Size(27, 21);
            this.lblAdresseVal.TabIndex = 3;
            this.lblAdresseVal.Text = "---";
            // 
            // lblCpTitre
            // 
            this.lblCpTitre.AutoSize = true;
            this.lblCpTitre.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCpTitre.Location = new System.Drawing.Point(250, 190);
            this.lblCpTitre.Name = "lblCpTitre";
            this.lblCpTitre.Size = new System.Drawing.Size(98, 21);
            this.lblCpTitre.TabIndex = 4;
            this.lblCpTitre.Text = "Code postal :";
            // 
            // lblCpVal
            // 
            this.lblCpVal.AutoSize = true;
            this.lblCpVal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCpVal.Location = new System.Drawing.Point(400, 190);
            this.lblCpVal.Name = "lblCpVal";
            this.lblCpVal.Size = new System.Drawing.Size(27, 21);
            this.lblCpVal.TabIndex = 5;
            this.lblCpVal.Text = "---";
            // 
            // lblVilleTitre
            // 
            this.lblVilleTitre.AutoSize = true;
            this.lblVilleTitre.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVilleTitre.Location = new System.Drawing.Point(250, 230);
            this.lblVilleTitre.Name = "lblVilleTitre";
            this.lblVilleTitre.Size = new System.Drawing.Size(47, 21);
            this.lblVilleTitre.TabIndex = 6;
            this.lblVilleTitre.Text = "Ville :";
            // 
            // lblVilleVal
            // 
            this.lblVilleVal.AutoSize = true;
            this.lblVilleVal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVilleVal.Location = new System.Drawing.Point(400, 230);
            this.lblVilleVal.Name = "lblVilleVal";
            this.lblVilleVal.Size = new System.Drawing.Size(27, 21);
            this.lblVilleVal.TabIndex = 7;
            this.lblVilleVal.Text = "---";
            // 
            // lblCoefNotorieteTitre
            // 
            this.lblCoefNotorieteTitre.AutoSize = true;
            this.lblCoefNotorieteTitre.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoefNotorieteTitre.Location = new System.Drawing.Point(250, 270);
            this.lblCoefNotorieteTitre.Name = "lblCoefNotorieteTitre";
            this.lblCoefNotorieteTitre.Size = new System.Drawing.Size(138, 21);
            this.lblCoefNotorieteTitre.TabIndex = 8;
            this.lblCoefNotorieteTitre.Text = "Coeff. de notoriété :";
            // 
            // lblCoefNotorieteVal
            // 
            this.lblCoefNotorieteVal.AutoSize = true;
            this.lblCoefNotorieteVal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoefNotorieteVal.Location = new System.Drawing.Point(400, 270);
            this.lblCoefNotorieteVal.Name = "lblCoefNotorieteVal";
            this.lblCoefNotorieteVal.Size = new System.Drawing.Size(27, 21);
            this.lblCoefNotorieteVal.TabIndex = 9;
            this.lblCoefNotorieteVal.Text = "---";
            // 
            // lblSpecialiteTitre
            // 
            this.lblSpecialiteTitre.AutoSize = true;
            this.lblSpecialiteTitre.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpecialiteTitre.Location = new System.Drawing.Point(250, 310);
            this.lblSpecialiteTitre.Name = "lblSpecialiteTitre";
            this.lblSpecialiteTitre.Size = new System.Drawing.Size(84, 21);
            this.lblSpecialiteTitre.TabIndex = 10;
            this.lblSpecialiteTitre.Text = "Spécialité :";
            // 
            // lblSpecialiteVal
            // 
            this.lblSpecialiteVal.AutoSize = true;
            this.lblSpecialiteVal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpecialiteVal.Location = new System.Drawing.Point(400, 310);
            this.lblSpecialiteVal.Name = "lblSpecialiteVal";
            this.lblSpecialiteVal.Size = new System.Drawing.Size(27, 21);
            this.lblSpecialiteVal.TabIndex = 11;
            this.lblSpecialiteVal.Text = "---";
            // 
            // pbLogo
            // 
            this.pbLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbLogo.BackColor = System.Drawing.Color.Transparent;
            this.pbLogo.Image = global::Alchifra.Properties.Resources.logo;
            this.pbLogo.Location = new System.Drawing.Point(680, 40);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(100, 100);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 12;
            this.pbLogo.TabStop = false;
            // 
            // pbUser
            // 
            this.pbUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pbUser.BackColor = System.Drawing.Color.Transparent;
            this.pbUser.Image = global::Alchifra.Properties.Resources.compte;
            this.pbUser.Location = new System.Drawing.Point(20, 380);
            this.pbUser.Name = "pbUser";
            this.pbUser.Size = new System.Drawing.Size(80, 80);
            this.pbUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbUser.TabIndex = 13;
            this.pbUser.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quitterToolStripMenuItem});
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.fichierToolStripMenuItem.Text = "Fichier";
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.quitterToolStripMenuItem.Text = "Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // lblDiplomeTitre
            // 
            this.lblDiplomeTitre.AutoSize = true;
            this.lblDiplomeTitre.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiplomeTitre.Location = new System.Drawing.Point(250, 350);
            this.lblDiplomeTitre.Name = "lblDiplomeTitre";
            this.lblDiplomeTitre.Size = new System.Drawing.Size(77, 21);
            this.lblDiplomeTitre.TabIndex = 15;
            this.lblDiplomeTitre.Text = "Diplôme :";
            // 
            // lblDiplomeVal
            // 
            this.lblDiplomeVal.AutoSize = true;
            this.lblDiplomeVal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiplomeVal.Location = new System.Drawing.Point(400, 350);
            this.lblDiplomeVal.Name = "lblDiplomeVal";
            this.lblDiplomeVal.Size = new System.Drawing.Size(27, 21);
            this.lblDiplomeVal.TabIndex = 16;
            this.lblDiplomeVal.Text = "---";
            // 
            // FormPraticien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.lblDiplomeVal);
            this.Controls.Add(this.lblDiplomeTitre);
            this.Controls.Add(this.pbUser);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.lblSpecialiteVal);
            this.Controls.Add(this.lblSpecialiteTitre);
            this.Controls.Add(this.lblCoefNotorieteVal);
            this.Controls.Add(this.lblCoefNotorieteTitre);
            this.Controls.Add(this.lblVilleVal);
            this.Controls.Add(this.lblVilleTitre);
            this.Controls.Add(this.lblCpVal);
            this.Controls.Add(this.lblCpTitre);
            this.Controls.Add(this.lblAdresseVal);
            this.Controls.Add(this.lblAdresseTitre);
            this.Controls.Add(this.lblNomPraticien);
            this.Controls.Add(this.cbPraticiens);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormPraticien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultation des Praticiens";
            this.Load += new System.EventHandler(this.FormPraticien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUser)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbPraticiens;
        private System.Windows.Forms.Label lblNomPraticien;
        private System.Windows.Forms.Label lblAdresseTitre;
        private System.Windows.Forms.Label lblAdresseVal;
        private System.Windows.Forms.Label lblCpTitre;
        private System.Windows.Forms.Label lblCpVal;
        private System.Windows.Forms.Label lblVilleTitre;
        private System.Windows.Forms.Label lblVilleVal;
        private System.Windows.Forms.Label lblCoefNotorieteTitre;
        private System.Windows.Forms.Label lblCoefNotorieteVal;
        private System.Windows.Forms.Label lblSpecialiteTitre;
        private System.Windows.Forms.Label lblSpecialiteVal;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.PictureBox pbUser;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.Label lblDiplomeTitre;
        private System.Windows.Forms.Label lblDiplomeVal;
    }
}
