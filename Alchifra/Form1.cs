using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Alchifra
{
    public partial class Form1 : Form
    {
        private string provider = "localhost";
        private string dataBase = "pharmasi";
        private string uid = "root";
        private string mdp = "";
        private ConnexionSql maConnexionSql;
        private MySqlCommand maRequete;

        public Form1()
        {
            InitializeComponent();
            textBoxMdp.PasswordChar = '*';
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonConnexion_Click(object sender, EventArgs e)
        {
            string login = textBoxLogin.Text;
            string password = textBoxMdp.Text;

            try
            {
                //Instanciation et ouverture de la connexion SQL
                maConnexionSql = ConnexionSql.GetInstance(provider, dataBase, uid, mdp);
                maConnexionSql.OpenConnexion();

                // Requête avec mot de passe hashé en SHA-256
                string requete = @"SELECT e.id_employe, e.nom, p.nom AS profil 
                   FROM Employe e 
                   JOIN Profil p ON e.id_profil = p.id_profil 
                   WHERE e.login = @login AND e.mdp = SHA2(@password, 256)";
                maRequete = new MySqlCommand(requete, maConnexionSql.GetConnexion());
                maRequete.Parameters.AddWithValue("@login", login);
                maRequete.Parameters.AddWithValue("@password", password);   

                // Déclaration et instanciation du DataReader qui récupère le résultat de la requête SQL
                MySqlDataReader nomReader = maRequete.ExecuteReader();

                // Lecture des enregistrements du DataReader
                string profil = "";
                int idEmploye = 0;
                if (nomReader.Read())
                {
                    idEmploye = nomReader.GetInt32("id_employe");
                    profil = nomReader.GetString("profil").ToLower();
                }
                
                // Fermeture du DataReader et de la connexion AVANT d'ouvrir une autre fenêtre
                nomReader.Close();
                maConnexionSql.CloseConnexion();

                if (profil != "")
                {
                    if (profil == "visiteur medical")
                    {
                        FormVisiteur formVisiteur = new FormVisiteur(login, idEmploye);
                        this.Hide();
                        formVisiteur.ShowDialog();
                        this.Show();
                    }
                    else if (profil == "responsable de secteur")
                    {
                        FormResponsable formResp = new FormResponsable(login, idEmploye);
                        this.Hide();
                        formResp.ShowDialog();
                        this.Show();
                    }
                    else if (profil == "delegue regional")
                    {
                        FormDelegue formDelegue = new FormDelegue(login, idEmploye);
                        this.Hide();
                        formDelegue.ShowDialog();
                        this.Show();
                    }
                    else
                    {
                        MessageBox.Show($"Bonjour {login}, vous êtes {profil} et ne pouvez pas vous connecter.");
                    }
                }
                else
                {
                    MessageBox.Show("Erreur login/mot de passe. Connexion impossible !");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message);
            }
        }

        private void textBoxLogin_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

