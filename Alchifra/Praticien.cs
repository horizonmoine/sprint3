using System;

namespace Alchifra
{
    public class Praticien
    {
        // Attributs privés
        private int idPraticien;
        private string nom;
        private string prenom;
        private string adresse;
        private string codePostal;
        private string ville;
        private string tel;
        private decimal coefficientNotoriete;
        private int idSpecialite;
        private int idDiplome;

        // Constructeur
        public Praticien(int idPraticien, string nom, string prenom, string adresse, string codePostal, string ville, string tel, decimal coefficientNotoriete, int idSpecialite, int idDiplome)
        {
            this.idPraticien = idPraticien;
            this.nom = nom;
            this.prenom = prenom;
            this.adresse = adresse;
            this.codePostal = codePostal;
            this.ville = ville;
            this.tel = tel;
            this.coefficientNotoriete = coefficientNotoriete;
            this.idSpecialite = idSpecialite;
            this.idDiplome = idDiplome;
        }

        // Accesseurs et Mutateurs (Propriétés)
        public int IdPraticien { get => idPraticien; set => idPraticien = value; }
        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public string Adresse { get => adresse; set => adresse = value; }
        public string CodePostal { get => codePostal; set => codePostal = value; }
        public string Ville { get => ville; set => ville = value; }
        public string Tel { get => tel; set => tel = value; }
        public decimal CoefficientNotoriete { get => coefficientNotoriete; set => coefficientNotoriete = value; }
        public int IdSpecialite { get => idSpecialite; set => idSpecialite = value; }
        public int IdDiplome { get => idDiplome; set => idDiplome = value; }
    }
}
