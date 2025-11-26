using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alchifra
{
    public partial class FormVisiteur : Form
    {
        public FormVisiteur(string login)
        {
            InitializeComponent();
            lblMessage.Text = "Bonjour " + login + " le visiteur médical";
        }
        private void FormVisiteur_Load(object sender, EventArgs e)
        {
            // Code à exécuter au chargement du formulaire
        }

        private void ficheDunPraticienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPraticien formPrat = new FormPraticien();
            formPrat.ShowDialog();
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }
    }
}
