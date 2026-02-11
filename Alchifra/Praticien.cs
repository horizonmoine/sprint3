using System;

namespace Alchifra
{
    public class Praticien
    {
        // Attributs privés
        private int id_praticien;
        private string nom;
        private string prenom;
        private string adresse;
        private string code_postal;
        private string ville;
        private string tel;
        private decimal coefficient_notoriete;
        private int id_specialite;
        private int id_diplome;

        // Constructeur
        public Praticien(int id_praticien, string nom, string prenom, string adresse, string code_postal, string ville, string tel, decimal coefficient_notoriete, int id_specialite, int id_diplome)
        {
            this.id_praticien = id_praticien;
            this.nom = nom;
            this.prenom = prenom;
            this.adresse = adresse;
            this.code_postal = code_postal;
            this.ville = ville;
            this.tel = tel;
            this.coefficient_notoriete = coefficient_notoriete;
            this.id_specialite = id_specialite;
            this.id_diplome = id_diplome;
        }

        // Accesseurs et Mutateurs (Propriétés)
        public int Id_praticien { get => id_praticien; set => id_praticien = value; }
        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public string Adresse { get => adresse; set => adresse = value; }
        public string Code_postal { get => code_postal; set => code_postal = value; }
        public string Ville { get => ville; set => ville = value; }
        public string Tel { get => tel; set => tel = value; }
        public decimal Coefficient_notoriete { get => coefficient_notoriete; set => coefficient_notoriete = value; }
        public int Id_specialite { get => id_specialite; set => id_specialite = value; }
        public int Id_diplome { get => id_diplome; set => id_diplome = value; }
    }
}
