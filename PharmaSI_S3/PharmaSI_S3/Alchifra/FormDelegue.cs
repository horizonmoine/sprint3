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
    public partial class FormDelegue : Form
    {
        public FormDelegue(string login)
        {
            InitializeComponent();
            lblMessage.Text = "Bonjour " + login + " le délégué régional";
            // branchement du menu "Fiche d'un produit"
            ficheDunProduitToolStripMenuItem.Click += ficheDunProduitToolStripMenuItem_Click;
        }
        private void FormDelegue_Load(object sender, EventArgs e)
        {

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