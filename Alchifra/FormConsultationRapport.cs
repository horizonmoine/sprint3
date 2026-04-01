using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Alchifra
{
    public partial class FormConsultationRapport : Form
    {
        private int idEmploye;
        private string profil;
        private DataTable dtRapports;

        public FormConsultationRapport(int idEmploye, string profil)
        {
            InitializeComponent();
            this.idEmploye = idEmploye;
            this.profil = profil;
        }

        private void FormConsultationRapport_Load(object sender, EventArgs e)
        {
            ChargerRapports();
        }

        private void ChargerRapports()
        {
            try
            {
                ConnexionSql maConnexion = ConnexionSql.GetInstance("localhost", "pharmasi", "pharmasi_user", "Pharma2025!");
                maConnexion.OpenConnexion();

                string requete = "";

                if (profil == "visiteur medical")
                {
                    requete = "SELECT id_rapport, CONCAT('Rapport n°', num_rapport, ' - ', p.nom) as display FROM rapport_visite r JOIN praticien p ON r.id_praticien = p.id_praticien WHERE id_visiteur = @idVisiteur ORDER BY num_rapport DESC";
                }
                else if (profil == "delegue regional")
                {
                    requete = @"SELECT r.id_rapport, CONCAT('Rapport n°', r.num_rapport, ' - ', p.nom, ' (', e.Nom, ')') as display 
                                FROM rapport_visite r 
                                JOIN praticien p ON r.id_praticien = p.id_praticien 
                                JOIN employe e ON r.id_visiteur = e.id_employe
                                WHERE r.id_visiteur = @idVisiteur 
                                   OR e.id_region = (SELECT id_region FROM employe WHERE id_employe = @idVisiteur)
                                ORDER BY r.date_rapport DESC, r.num_rapport DESC";
                }
                else if (profil == "responsable de secteur")
                {
                    requete = @"SELECT r.id_rapport, CONCAT('Rapport n°', r.num_rapport, ' - ', p.nom, ' (', e.Nom, ')') as display 
                                FROM rapport_visite r 
                                JOIN praticien p ON r.id_praticien = p.id_praticien 
                                JOIN employe e ON r.id_visiteur = e.id_employe
                                WHERE r.id_visiteur = @idVisiteur 
                                   OR e.id_secteur = (SELECT id_secteur FROM employe WHERE id_employe = @idVisiteur)
                                ORDER BY r.date_rapport DESC, r.num_rapport DESC";
                }

                MySqlCommand cmd = new MySqlCommand(requete, maConnexion.GetConnexion());
                cmd.Parameters.AddWithValue("@idVisiteur", idEmploye);
                
                MySqlDataReader reader = cmd.ExecuteReader();
                dtRapports = new DataTable();
                dtRapports.Load(reader);
                maConnexion.CloseConnexion();

                cbRapport.DataSource = dtRapports;
                cbRapport.DisplayMember = "display";
                cbRapport.ValueMember = "id_rapport";

                if (cbRapport.Items.Count > 0)
                    cbRapport.SelectedIndex = 0;
                else
                    MessageBox.Show("Aucun rapport trouvé.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du chargement des rapports : " + ex.Message);
            }
        }

        private void cbRapport_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbRapport.SelectedValue != null && int.TryParse(cbRapport.SelectedValue.ToString(), out int idRapport))
            {
                AfficherDetailsRapport(idRapport);
            }
        }

        private void btnValiderSelection_Click(object sender, EventArgs e)
        {
            if (cbRapport.SelectedValue != null && int.TryParse(cbRapport.SelectedValue.ToString(), out int idRapport))
            {
                AfficherDetailsRapport(idRapport);
            }
            else
            {
                MessageBox.Show("Veuillez d'abord sélectionner un rapport.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        
        private void AfficherDetailsRapport(int idRapport)
        {
            try
            {
                ConnexionSql maConnexion = ConnexionSql.GetInstance("localhost", "pharmasi", "pharmasi_user", "Pharma2025!");
                maConnexion.OpenConnexion();

                // 1. Détails du rapport
                string reqDetails = @"SELECT r.*, p.nom as nom_praticien, p.prenom as prenom_praticien, e.Nom as nom_auteur, e.Prenom as prenom_auteur 
                                     FROM rapport_visite r 
                                     JOIN praticien p ON r.id_praticien = p.id_praticien
                                     JOIN employe e ON r.id_visiteur = e.id_employe
                                     WHERE r.id_rapport = @idRapport";
                
                MySqlCommand cmdDetails = new MySqlCommand(reqDetails, maConnexion.GetConnexion());
                cmdDetails.Parameters.AddWithValue("@idRapport", idRapport);
                MySqlDataReader readerDetails = cmdDetails.ExecuteReader();

                if (readerDetails.Read())
                {
                    lblDateVal.Text = Convert.ToDateTime(readerDetails["date_rapport"]).ToShortDateString();
                    lblPraticienVal.Text = readerDetails["nom_praticien"].ToString() + " " + readerDetails["prenom_praticien"].ToString();
                    lblMotifVal.Text = readerDetails["motif"].ToString();
                    txtBilan.Text = readerDetails["bilan"].ToString();

                    int idAuteur = Convert.ToInt32(readerDetails["id_visiteur"]);
                    if (idAuteur == idEmploye)
                    {
                        lblAuteur.Visible = false;
                        lblAuteurVal.Visible = false;
                    }
                    else
                    {
                        lblAuteur.Visible = true;
                        lblAuteurVal.Visible = true;
                        lblAuteurVal.Text = readerDetails["nom_auteur"].ToString() + " " + readerDetails["prenom_auteur"].ToString();
                    }
                }
                readerDetails.Close();

                // 2. Produits offerts
                string reqProduits = @"SELECT p.nom_commercial, o.quantite 
                                      FROM offrir o 
                                      JOIN produit p ON o.id_produit = p.id_produit 
                                      WHERE o.id_rapport = @idRapport";
                
                MySqlCommand cmdProduits = new MySqlCommand(reqProduits, maConnexion.GetConnexion());
                cmdProduits.Parameters.AddWithValue("@idRapport", idRapport);
                
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmdProduits);
                DataTable dtProduitsOfferts = new DataTable();
                adapter.Fill(dtProduitsOfferts);
                
                dgvProduits.DataSource = dtProduitsOfferts;
                dgvProduits.Columns[0].HeaderText = "Produit";
                dgvProduits.Columns[1].HeaderText = "Quantité";

                maConnexion.CloseConnexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du chargement des détails : " + ex.Message);
            }
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
