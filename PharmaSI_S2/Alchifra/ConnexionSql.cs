using System;
using MySql.Data.MySqlClient;
using System.Windows.Forms;


namespace Alchifra 
{
    public class ConnexionSql
    {
        private static ConnexionSql connexion = null;
        private MySqlConnection cnx;
        private string connString;

        // Constructeur privé car appelé par getInstance
        private ConnexionSql(string unProvider, string uneDataBase, string unUid, string unMdp)
        {
            Initialize(unProvider, uneDataBase, unUid, unMdp);
        }

        //Initialisation de la connexion avec les paramètres de connexion
        private void Initialize(string unProvider, string uneDataBase, string unUid, string unMdp)
        {
            try
            {
                connString = $"SERVER={unProvider};DATABASE={uneDataBase};UID={unUid};PASSWORD={unMdp}";
                cnx = new MySqlConnection(connString);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        //Méthode de création d'une instance de connexion si elle n'existe pas (singleton)
        public static ConnexionSql GetInstance(string unProvider, string uneDataBase, string unUid, string unMdp)
        {
            try
            {
                if (connexion == null)
                {
                    // Premier appel
                    connexion = new ConnexionSql(unProvider, uneDataBase, unUid, unMdp);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Erreur lors de la création de la connexion : " + e.Message,
                                "Erreur de connexion",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }

            return connexion;
        }


        //Récupération de la connexion
        public MySqlConnection GetConnexion()
        {
            return this.cnx;
        }

        //Ouverture de la connexion
        public void OpenConnexion()
        {
            try
            {
                cnx.Open();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        //Fermeture de la connexion
        public void CloseConnexion()
        {
            cnx.Close();
        }

        //Exécutiuon d'une requête
        public MySqlCommand ReqExec(string req)
        {
            MySqlCommand mysqlCmd = new MySqlCommand(req, this.cnx);
            return mysqlCmd;
        }
    }
}



