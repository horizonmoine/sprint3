using System;

namespace Alchifra
{
    public class RapportVisite
    {
        // Attributs privés
        private int idRapport;
        private DateTime dateVisite;
        private string motif;
        private string bilan;
        private int idVisiteur;
        private int idPraticien;

        // Constructeur
        public RapportVisite(int idRapport, DateTime dateVisite, string motif, string bilan, int idVisiteur, int idPraticien)
        {
            this.idRapport = idRapport;
            this.dateVisite = dateVisite;
            this.motif = motif;
            this.bilan = bilan;
            this.idVisiteur = idVisiteur;
            this.idPraticien = idPraticien;
        }

        // Accesseurs et Mutateurs (Propriétés)
        public int IdRapport { get => idRapport; set => idRapport = value; }
        public DateTime DateVisite { get => dateVisite; set => dateVisite = value; }
        public string Motif { get => motif; set => motif = value; }
        public string Bilan { get => bilan; set => bilan = value; }
        public int IdVisiteur { get => idVisiteur; set => idVisiteur = value; }
        public int IdPraticien { get => idPraticien; set => idPraticien = value; }
    }
}
