-- ============================================================
-- Sprint 5 – Migration SQL
-- À exécuter UNE SEULE FOIS dans phpMyAdmin / MySQL
-- ============================================================

-- 1. Table des rapports de visite
CREATE TABLE IF NOT EXISTS rapport_visite (
    id_rapport INT AUTO_INCREMENT PRIMARY KEY,
    date_visite DATE NOT NULL,
    motif VARCHAR(50) NOT NULL,
    bilan TEXT NOT NULL,
    id_visiteur INT NOT NULL,
    id_praticien INT NOT NULL,
    FOREIGN KEY (id_visiteur) REFERENCES Employe(id_employe),
    FOREIGN KEY (id_praticien) REFERENCES Praticien(id_praticien)
);

-- 2. Table des produits offerts lors d'une visite (max 2 produits par rapport)
CREATE TABLE IF NOT EXISTS rapport_produit (
    id_rapport INT NOT NULL,
    id_produit INT NOT NULL,
    nb_echantillons INT NOT NULL DEFAULT 0,
    PRIMARY KEY (id_rapport, id_produit),
    FOREIGN KEY (id_rapport) REFERENCES rapport_visite(id_rapport),
    FOREIGN KEY (id_produit) REFERENCES produit(id_produit)
);

-- 3. Hashage des mots de passe existants en SHA-256
-- /!\ NE PAS RELANCER si déjà exécuté, sinon les mots de passe seront doublement hashés !
UPDATE Employe SET mdp = SHA2(mdp, 256);
