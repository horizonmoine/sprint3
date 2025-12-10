using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Alchifra
{
    public partial class FormProduit : Form
    {
        private DataTable dtProduits;

        public FormProduit()
        {
            InitializeComponent();
        }

        private void FormProduit_Load(object sender, EventArgs e)
        {
            ChargerProduits();
        }

        // Charger la liste des produits dans la CBX
        private void ChargerProduits()
        {
            // Utilisateur securise (et plus root)
            ConnexionSql maConnexion = ConnexionSql.GetInstance("localhost", "pharmasi", "pharmasi_user", "Pharma2025!");
            maConnexion.OpenConnexion();

            string requete = @"
                SELECT p.id_produit,
                       p.numero_produit,
                       p.nom_commercial,
                       p.prix,
                       p.effets,
                       p.contre_indications,
                       p.interaction,
                       f.nom_famille
                FROM produit p
                LEFT JOIN famille f ON p.id_famille = f.id_famille
                ORDER BY p.nom_commercial ASC";

            MySqlCommand cmd = maConnexion.ReqExec(requete);
            MySqlDataReader reader = cmd.ExecuteReader();

            dtProduits = new DataTable();
            dtProduits.Load(reader);

            maConnexion.CloseConnexion();

            cbProduitS.DataSource = dtProduits;
            cbProduitS.DisplayMember = "nom_commercial";
            cbProduitS.ValueMember = "id_produit";

            if (cbProduitS.Items.Count > 0)
                cbProduitS.SelectedIndex = 0;
        }

        // change produit + afiche complet
        private void cbProduitS_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbProduitS.SelectedIndex != -1 && dtProduits != null)
            {
                DataRowView rowView = (DataRowView)cbProduitS.SelectedItem;
                DataRow row = rowView.Row;

                //  Informations  
               
                txtFamille.Text = row["nom_famille"].ToString();
                txtPrix.Text = row["prix"].ToString() + " €";
                txtNumero.Text = row["numero_produit"].ToString();

                // Informations medicales 
                rtbEffets.Text = row["effets"].ToString();
                rtbContreInterdications.Text = row["contre_indications"].ToString();
                rtbInteractions.Text = row["interaction"].ToString();

                //  Composants 
                int idProduit = Convert.ToInt32(row["id_produit"]);
                ChargerComposants(idProduit);
            }
        }

        // charger les composants depuis la DTV
        private void ChargerComposants(int idProduit)
        {
            ConnexionSql maConnexion = ConnexionSql.GetInstance("localhost", "pharmasi", "pharmasi_user", "Pharma2025!");
            maConnexion.OpenConnexion();

            string requete = @"
                SELECT c.nom_composant AS Composant,
                       pc.quantite      AS Quantite
                FROM produit_composant pc
                INNER JOIN composant c ON pc.id_composant = c.id_composant
                WHERE pc.id_produit = " + idProduit;

            MySqlCommand cmd = maConnexion.ReqExec(requete);
            MySqlDataReader reader = cmd.ExecuteReader();

            DataTable dtComposants = new DataTable();
            dtComposants.Load(reader);

            maConnexion.CloseConnexion();

            dgvComposants.DataSource = dtComposants;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
