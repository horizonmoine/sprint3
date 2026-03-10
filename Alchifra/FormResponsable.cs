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
    public partial class FormResponsable : Form
    {
        private int idEmploye;

        public FormResponsable(string login, int idEmploye)
        {
            InitializeComponent();
            this.idEmploye = idEmploye;
            lblMessage.Text = "Bonjour " + login + " le responsable de secteur";
            // branchement du menu "Fiche d'un produit"
            ficheDunProduitToolStripMenuItem.Click += ficheDunProduitToolStripMenuItem_Click;
            // branchement du menu "Consulter les rapports"
            consulterLesRapportsToolStripMenuItem.Click += consulterLesRapportsToolStripMenuItem_Click;
        }

        private void consulterLesRapportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormConsultationRapport formCons = new FormConsultationRapport(idEmploye, "responsable de secteur");
            formCons.ShowDialog();
        }

        private void FormResponsable_Load(object sender, EventArgs e)
        {
            // Code à exécuter au chargement du formulaire
        }
        private void ficheDunProduitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormProduit formProd = new FormProduit();
            formProd.ShowDialog();  // ouvre la fiche produit
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

