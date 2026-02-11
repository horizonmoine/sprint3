using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Alchifra
{
    public partial class FormRapportVisite : Form
    {
        private int idVisiteur;
        private DataTable dtPraticiens;
        private DataTable dtProduits;

        public FormRapportVisite(int idVisiteur)
        {
            InitializeComponent();
            this.idVisiteur = idVisiteur;
        }

        private void FormRapportVisite_Load(object sender, EventArgs e)
        {
            ChargerPraticiens();
            ChargerProduits();
            ChargerNumeroRapport();
        }

        /// <summary>
        /// Charge la liste des praticiens dans la ComboBox
        /// </summary>
        private void ChargerPraticiens()
        {
            ConnexionSql maConnexion = ConnexionSql.GetInstance("localhost", "pharmasi", "pharmasi_user", "Pharma2025!");
            maConnexion.OpenConnexion();

            string requete = @"SELECT id_praticien, CONCAT(nom, ' ', prenom) AS nom_complet 
                               FROM Praticien ORDER BY nom ASC";

            MySqlCommand cmd = maConnexion.ReqExec(requete);
            MySqlDataReader reader = cmd.ExecuteReader();

            dtPraticiens = new DataTable();
            dtPraticiens.Load(reader);

            maConnexion.CloseConnexion();

            cbPraticien.DataSource = dtPraticiens;
            cbPraticien.DisplayMember = "nom_complet";
            cbPraticien.ValueMember = "id_praticien";

            if (cbPraticien.Items.Count > 0)
                cbPraticien.SelectedIndex = 0;
        }

        /// <summary>
        /// Charge la liste des produits dans les deux ComboBox
        /// </summary>
        private void ChargerProduits()
        {
            ConnexionSql maConnexion = ConnexionSql.GetInstance("localhost", "pharmasi", "pharmasi_user", "Pharma2025!");
            maConnexion.OpenConnexion();

            string requete = @"SELECT id_produit, nom_commercial 
                               FROM produit ORDER BY nom_commercial ASC";

            MySqlCommand cmd = maConnexion.ReqExec(requete);
            MySqlDataReader reader = cmd.ExecuteReader();

            dtProduits = new DataTable();
            dtProduits.Load(reader);

            maConnexion.CloseConnexion();

            DataRow ligneVide = dtProduits.NewRow();
            ligneVide["id_produit"] = 0;
            ligneVide["nom_commercial"] = "(Aucun)";
            dtProduits.Rows.InsertAt(ligneVide, 0);

            // Produit 1
            cbProduit1.DataSource = dtProduits.Copy();
            cbProduit1.DisplayMember = "nom_commercial";
            cbProduit1.ValueMember = "id_produit";
            cbProduit1.SelectedIndex = 0;

            // Produit 2
            cbProduit2.DataSource = dtProduits.Copy();
            cbProduit2.DisplayMember = "nom_commercial";
            cbProduit2.ValueMember = "id_produit";
            cbProduit2.SelectedIndex = 0;
        }

        /// Récupère le prochain numéro de rapport (auto-increment)
        private void ChargerNumeroRapport()
        {
            ConnexionSql maConnexion = ConnexionSql.GetInstance("localhost", "pharmasi", "pharmasi_user", "Pharma2025!");
            maConnexion.OpenConnexion();

            string requete = @"SELECT IFNULL(MAX(id_rapport), 0) + 1 AS prochain_id FROM rapport_visite";

            MySqlCommand cmd = maConnexion.ReqExec(requete);
            MySqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                lblNumRapportVal.Text = reader.GetInt32(0).ToString();
            }

            reader.Close();
            maConnexion.CloseConnexion();
        }

        /// Validation et enregistrement du rapport de visite
        private void btnValider_Click(object sender, EventArgs e)
        {
            // Validation des champs obligatoires
            if (cbPraticien.SelectedIndex == -1)
            {
                MessageBox.Show("Le champ Praticien doit être renseigné.", "Erreur de saisie",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cbMotif.SelectedIndex == -1)
            {
                MessageBox.Show("Le champ Motif doit être renseigné.", "Erreur de saisie",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtBilan.Text))
            {
                MessageBox.Show("Le champ Bilan doit être renseigné.", "Erreur de saisie",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validation de la date
            DateTime dateVisite = dtpDateVisite.Value.Date;
            if (dateVisite > DateTime.Now.Date)
            {
                MessageBox.Show("La date doit être valide (pas dans le futur).", "Erreur de saisie",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                ConnexionSql maConnexion = ConnexionSql.GetInstance("localhost", "pharmasi", "pharmasi_user", "Pharma2025!");
                maConnexion.OpenConnexion();

                // 1. Insertion du rapport de visite
                string requeteRapport = @"INSERT INTO rapport_visite (date_rapport, motif, bilan, id_visiteur, id_praticien) 
                                          VALUES (@dateVisite, @motif, @bilan, @idVisiteur, @idPraticien)";

                MySqlCommand cmdRapport = new MySqlCommand(requeteRapport, maConnexion.GetConnexion());
                cmdRapport.Parameters.AddWithValue("@dateVisite", dateVisite.ToString("yyyy-MM-dd"));
                cmdRapport.Parameters.AddWithValue("@motif", cbMotif.SelectedItem.ToString());
                cmdRapport.Parameters.AddWithValue("@bilan", txtBilan.Text);
                cmdRapport.Parameters.AddWithValue("@idVisiteur", idVisiteur);
                cmdRapport.Parameters.AddWithValue("@idPraticien", Convert.ToInt32(cbPraticien.SelectedValue));

                cmdRapport.ExecuteNonQuery();

                // Récupérer l'ID du rapport inséré
                long idRapport = cmdRapport.LastInsertedId;

                // 2. Insertion du produit 1 si sélectionné
                if (cbProduit1.SelectedIndex > 0 && Convert.ToInt32(cbProduit1.SelectedValue) > 0)
                {
                    string requeteProduit = @"INSERT INTO rapport_produit (id_rapport, id_produit, nb_echantillons) 
                                              VALUES (@idRapport, @idProduit, @nbEchantillons)";

                    MySqlCommand cmdProduit1 = new MySqlCommand(requeteProduit, maConnexion.GetConnexion());
                    cmdProduit1.Parameters.AddWithValue("@idRapport", idRapport);
                    cmdProduit1.Parameters.AddWithValue("@idProduit", Convert.ToInt32(cbProduit1.SelectedValue));
                    cmdProduit1.Parameters.AddWithValue("@nbEchantillons", (int)nudEchantillons1.Value);

                    cmdProduit1.ExecuteNonQuery();
                }

                // 3. Insertion du produit 2 si sélectionné
                if (cbProduit2.SelectedIndex > 0 && Convert.ToInt32(cbProduit2.SelectedValue) > 0)
                {
                    string requeteProduit = @"INSERT INTO rapport_produit (id_rapport, id_produit, nb_echantillons) 
                                              VALUES (@idRapport, @idProduit, @nbEchantillons)";

                    MySqlCommand cmdProduit2 = new MySqlCommand(requeteProduit, maConnexion.GetConnexion());
                    cmdProduit2.Parameters.AddWithValue("@idRapport", idRapport);
                    cmdProduit2.Parameters.AddWithValue("@idProduit", Convert.ToInt32(cbProduit2.SelectedValue));
                    cmdProduit2.Parameters.AddWithValue("@nbEchantillons", (int)nudEchantillons2.Value);

                    cmdProduit2.ExecuteNonQuery();
                }

                maConnexion.CloseConnexion();

                MessageBox.Show("Le rapport de visite n° " + idRapport + " a été enregistré avec succès.",
                    "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de l'enregistrement : " + ex.Message,
                    "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// Réinitialise tous les champs du formulaire
        private void btnReinitialiser_Click(object sender, EventArgs e)
        {
            dtpDateVisite.Value = DateTime.Now;

            if (cbPraticien.Items.Count > 0)
                cbPraticien.SelectedIndex = 0;

            cbMotif.SelectedIndex = -1;
            txtBilan.Text = "";

            if (cbProduit1.Items.Count > 0)
                cbProduit1.SelectedIndex = 0;
            nudEchantillons1.Value = 0;

            if (cbProduit2.Items.Count > 0)
                cbProduit2.SelectedIndex = 0;
            nudEchantillons2.Value = 0;
        }

        /// Annule et fermer le formulaire
        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
