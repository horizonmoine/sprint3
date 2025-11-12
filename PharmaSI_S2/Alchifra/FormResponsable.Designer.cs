namespace Alchifra
{
    partial class FormResponsable
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
            this.lblMessage = new System.Windows.Forms.Label();
            this.btnRapports = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnBudget = new System.Windows.Forms.Button();
            this.btnStatistiques = new System.Windows.Forms.Button();
            this.btnStocks = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.Location = new System.Drawing.Point(265, 232);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(0, 20);
            this.lblMessage.TabIndex = 2;
            // 
            // btnRapports
            // 
            this.btnRapports.Location = new System.Drawing.Point(37, 113);
            this.btnRapports.Name = "btnRapports";
            this.btnRapports.Size = new System.Drawing.Size(109, 32);
            this.btnRapports.TabIndex = 5;
            this.btnRapports.Text = "Rapports";
            this.btnRapports.UseVisualStyleBackColor = true;
            // 
            // btnLogOut
            // 
            this.btnLogOut.Image = global::Alchifra.Properties.Resources.deco3;
            this.btnLogOut.Location = new System.Drawing.Point(58, 424);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(63, 49);
            this.btnLogOut.TabIndex = 8;
            this.btnLogOut.UseVisualStyleBackColor = true;
            // 
            // pictureBox3
            // 
            this.pictureBox3.ErrorImage = global::Alchifra.Properties.Resources.compte;
            this.pictureBox3.Image = global::Alchifra.Properties.Resources.compte;
            this.pictureBox3.Location = new System.Drawing.Point(48, 25);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(82, 69);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.ErrorImage = global::Alchifra.Properties.Resources.profil2;
            this.pictureBox2.Image = global::Alchifra.Properties.Resources.profil2;
            this.pictureBox2.Location = new System.Drawing.Point(-45, -13);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(268, 526);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.ErrorImage = global::Alchifra.Properties.Resources.logo;
            this.pictureBox1.Image = global::Alchifra.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(827, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(92, 92);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // btnBudget
            // 
            this.btnBudget.Location = new System.Drawing.Point(37, 178);
            this.btnBudget.Name = "btnBudget";
            this.btnBudget.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnBudget.Size = new System.Drawing.Size(109, 32);
            this.btnBudget.TabIndex = 9;
            this.btnBudget.Text = "Budget";
            this.btnBudget.UseVisualStyleBackColor = true;
            // 
            // btnStatistiques
            // 
            this.btnStatistiques.Location = new System.Drawing.Point(37, 241);
            this.btnStatistiques.Name = "btnStatistiques";
            this.btnStatistiques.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnStatistiques.Size = new System.Drawing.Size(109, 32);
            this.btnStatistiques.TabIndex = 10;
            this.btnStatistiques.Text = "Statistiques";
            this.btnStatistiques.UseVisualStyleBackColor = true;
            // 
            // btnStocks
            // 
            this.btnStocks.Location = new System.Drawing.Point(37, 303);
            this.btnStocks.Name = "btnStocks";
            this.btnStocks.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnStocks.Size = new System.Drawing.Size(109, 32);
            this.btnStocks.TabIndex = 11;
            this.btnStocks.Text = "Stocks";
            this.btnStocks.UseVisualStyleBackColor = true;
            // 
            // FormResponsable
            // 
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(934, 502);
            this.Controls.Add(this.btnStocks);
            this.Controls.Add(this.btnStatistiques);
            this.Controls.Add(this.btnBudget);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.btnRapports);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.pictureBox2);
            this.Name = "FormResponsable";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnRapports;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnBudget;
        private System.Windows.Forms.Button btnStatistiques;
        private System.Windows.Forms.Button btnStocks;
    }
}