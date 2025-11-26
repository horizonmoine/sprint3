using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Alchifra
{
    public partial class FormPraticien : Form
    {
        private DataTable dtPraticiens;

        public FormPraticien()
        {
            InitializeComponent();
        }

        private void FormPraticien_Load(object sender, EventArgs e)
        {
            ChargerPraticiens();
        }

        private void ChargerPraticiens()
        {
            // 1. Connexion
            ConnexionSql maConnexion = ConnexionSql.GetInstance("localhost", "pharmasi", "root", ""); 
            maConnexion.OpenConnexion();

            // 2. Requête SQL
            string requete = @"
                SELECT P.id_praticien, P.nom, P.prenom, P.adresse, P.code_postal, P.ville, P.coefficient_notoriete, S.nom AS nom_specialite, D.nom AS nom_diplome
                FROM Praticien P
                INNER JOIN Specialite S ON P.id_specialite = S.id_specialite
                INNER JOIN Diplome D ON P.id_diplome = D.id_diplome
                ORDER BY P.nom ASC";

            MySqlCommand commande = maConnexion.ReqExec(requete);
            MySqlDataReader reader = commande.ExecuteReader();

            // 3. Remplissage de la DataTable
            dtPraticiens = new DataTable();
            dtPraticiens.Load(reader);

            maConnexion.CloseConnexion();

            // 4. Ajout d'une colonne calculée pour l'affichage dans la ComboBox
            dtPraticiens.Columns.Add("NomComplet", typeof(string), "nom + ' ' + prenom");

            // 5. Liaison avec la ComboBox
            cbPraticiens.DataSource = dtPraticiens;
            cbPraticiens.DisplayMember = "NomComplet";
            cbPraticiens.ValueMember = "id_praticien";

            // 6. Déclencher l'affichage du premier élément si existant
            if (cbPraticiens.Items.Count > 0)
            {
                cbPraticiens.SelectedIndex = 0;
            }
        }

        private void cbPraticiens_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbPraticiens.SelectedIndex != -1 && dtPraticiens != null)
            {
                // Récupérer la ligne sélectionnée via le CurrencyManager de la ComboBox ou directement par l'index
                // Comme la source est la DataTable, SelectedItem est un DataRowView
                DataRowView rowView = (DataRowView)cbPraticiens.SelectedItem;
                DataRow row = rowView.Row;

                // Mise à jour des labels
                lblNomPraticien.Text = row["nom"].ToString().ToUpper() + " " + row["prenom"].ToString();
                lblAdresseVal.Text = row["adresse"].ToString();
                lblCpVal.Text = row["code_postal"].ToString();
                lblVilleVal.Text = row["ville"].ToString();
                lblCoefNotorieteVal.Text = row["coefficient_notoriete"].ToString();
                lblSpecialiteVal.Text = row["nom_specialite"].ToString();
                lblDiplomeVal.Text = row["nom_diplome"].ToString();
            }
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
