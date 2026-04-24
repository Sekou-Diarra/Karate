🥋 Club Karaté - Mission 3
📝 Présentation du projet
Ce projet a été réalisé dans le cadre de ma formation en BTS SIO (SLAM). L'objectif est de fournir une solution logicielle pour la gestion des compétitions d'un club de karaté. Cette troisième mission se concentre sur l'administration des ressources humaines (entraîneurs) et le suivi des performances des compétiteurs.

🚀 Fonctionnalités principales
Le logiciel s'articule autour de trois tâches majeures (Mission 3) :

T1.3 - Gestion des entraîneurs : Module CRUD complet permettant de créer, modifier ou supprimer un entraîneur. Intègre une règle métier stricte : un entraîneur ne peut être membre du club et ne doit entraîner qu'un seul club.

T2.3 - Affectation des jurys : Gestion des affectations des entraîneurs en tant que membres du jury pour les compétitions.

T2.6 - Bilan par saison : Génération d'un récapitulatif historique pour un compétiteur donné, affichant la date, le lieu et la note globale obtenue par saison.

🛠️ Stack Technique
Langage : C# (.NET Framework)

IDE : Visual Studio Enterprise

Base de données : MySQL via WampServer

Administration DB : PHPMyAdmin

Gestion de version : Git / GitHub

📂 Structure du projet
Plaintext
├── ClubKarate/
│   ├── Forms/              # Formulaires Windows (T1.3, T2.3, T2.6)
│   ├── Models/             # Classes métier (Entraineur, Jury, Competition)
│   ├── Services/           # Gestion de la connexion MySQL (DatabaseManager)
│   └── Program.cs          # Point d'entrée de l'application
├── SQL/
│   └── db_karate.sql       # Script d'export de la base de données
└── README.md
⚙️ Installation
Base de données :

Lancer WampServer.

Importer le fichier db_karate.sql dans PHPMyAdmin.

Configuration du projet :

Ouvrir la solution .sln sous Visual Studio.

Vérifier la chaîne de connexion dans la classe de gestion de base de données (serveur, utilisateur, mot de passe).

Exécution :

Générer la solution et lancer l'application (F5).

🧪 Tests effectués
Contrôles de saisie : Vérification des formats de données et des champs obligatoires dans les formulaires.

Intégrité référentielle : Tests sur les contraintes MySQL pour empêcher la suppression d'un entraîneur affecté à un jury actif.

Requêtes SQL : Validation des jointures complexes pour l'affichage du bilan par saison.

👤 Auteur
Sékou Diarra - Étudiant en BTS SIO option SLAM (Solutions Logicielles et Applications Métier).
