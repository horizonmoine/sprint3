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

                string requete = @"SELECT e.nom, p.nom AS profil 
                   FROM employe e 
                   JOIN Profil p ON e.id_profil = p.id_profil 
                   WHERE e.login = @login AND e.mdp = @password";
                maRequete = new MySqlCommand(requete, maConnexionSql.GetConnexion());
                maRequete.Parameters.AddWithValue("@login", login);
                maRequete.Parameters.AddWithValue("@password", password);   

                // Déclaration et instanciation du DataReader qui récupère le résultat de la requête SQL
                MySqlDataReader nomReader = maRequete.ExecuteReader();

                // Lecture des enregistrements du DataReader
                if (nomReader.Read())
                {
                    string profil = nomReader.GetString("profil").ToLower();

                    if (profil == "visiteur medical")
                    {
                        FormVisiteur formVisiteur = new FormVisiteur(login);
                        this.Hide();
                        formVisiteur.ShowDialog();
                        this.Show();
                    }
                    else if (profil == "responsable de secteur")
                    {
                        FormResponsable formResp = new FormResponsable(login);
                        this.Hide();
                        formResp.ShowDialog();
                        this.Show();
                    }
                    else if (profil == "delegue regional")
                    {
                        FormDelegue formDelegue = new FormDelegue(login);
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

                // Fermeture du DataReader à la fin de son utilisation
                nomReader.Close();

                // Fermeture de la connexion SQL
                maConnexionSql.CloseConnexion();
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

