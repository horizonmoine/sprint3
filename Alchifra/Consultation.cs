using System;

namespace Alchifra
{
    public class Consultation
    {
        // Attributs privés
        private int idConsultation;
        private DateTime dateConsultation;
        private string motif;
        private string bilan;
        private int idVisiteur;
        private int idPraticien;

        // Constructeur
        public Consultation(int idConsultation, DateTime dateConsultation, string motif, string bilan, int idVisiteur, int idPraticien)
        {
            this.idConsultation = idConsultation;
            this.dateConsultation = dateConsultation;
            this.motif = motif;
            this.bilan = bilan;
            this.idVisiteur = idVisiteur;
            this.idPraticien = idPraticien;
        }

        // Accesseurs et Mutateurs (Propriétés)
        public int IdConsultation { get => idConsultation; set => idConsultation = value; }
        public DateTime DateConsultation { get => dateConsultation; set => dateConsultation = value; }
        public string Motif { get => motif; set => motif = value; }
        public string Bilan { get => bilan; set => bilan = value; }
        public int IdVisiteur { get => idVisiteur; set => idVisiteur = value; }
        public int IdPraticien { get => idPraticien; set => idPraticien = value; }
    }
}
