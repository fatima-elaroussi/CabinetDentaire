CREATE TABLE Patient (
    nDossier INT PRIMARY KEY,
    nom_patient VARCHAR(255),
    prenom_patient VARCHAR(255),
    cin_patient VARCHAR(50),
    age_patient INT,
    sexe_patient VARCHAR(10),
    adresse_patient VARCHAR(255),
    tele_patient VARCHAR(20),
    fixe_patient VARCHAR(20),
    email_patient VARCHAR(255),
    dateNaissance DATE,
    assurance VARCHAR(100),
    typeAssurance VARCHAR(100),
    obs VARCHAR(255),
    date_dossier DATE
);
